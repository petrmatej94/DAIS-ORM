





alter TRIGGER kontrolaBodu ON Ridic AFTER UPDATE AS
BEGIN
	DECLARE @inserted_uID INT;
	DECLARE @pocet_bodu int;

	--select * from inserted;
	SET @inserted_uID = (SELECT uID from inserted);
	SET @pocet_bodu = (SELECT Pocet_bodu from Ridic where uID = @inserted_uID);

	IF @pocet_bodu <= 0
		print 'Odebrat ridici RP'
END;

drop trigger kontrolabodu




--vypisu zaznam a musim aktualizovat body jako transakci

ALTER PROCEDURE NovyZaznam(@castka INT, @uID INT, @zID INT, @pID INT, @expirace_dni INT) AS
BEGIN
	BEGIN TRY
		DECLARE @date DATETIME;
		DECLARE @expirace DATETIME;
		DECLARE @zazID INT;
		DECLARE @odebrat_bodu INT;

		SET @odebrat_bodu = (SELECT Bodovy_trest FROM Typ WHERE pID = @pID);

		SET @zazID = (SELECT MAX(zazID) from Zaznam) + 1;

		SET @date = GETDATE();
		SET @expirace = DATEADD(DAY, @expirace_dni, @date);

		BEGIN TRANSACTION
		IF @expirace_dni = 0	--ridic zaplatil pokutu na miste
			INSERT INTO Zaznam(Castka, Odebrano_bodu, Datum_zadani, Datum_expirace, Datum_provedeni, uID, zID, pID) values
			(@castka, @odebrat_bodu, @date, @date, @date, @uID, @zID, @pID); 
	
		ELSE
			INSERT INTO Zaznam(Castka, Odebrano_bodu, Datum_zadani, Datum_expirace, Datum_provedeni, uID, zID, pID) values
			(@castka, @odebrat_bodu, @date, @expirace, NULL, @uID, @zID, @pID); 

		UPDATE Ridic SET Pocet_bodu = Pocet_bodu - @odebrat_bodu WHERE uID = @uID;
		print 'ok'
		COMMIT;
	END TRY
	BEGIN CATCH
		print 'neco je spatne'
		ROLLBACK;
	END CATCH;
END;


EXEC NovyZaznam 3500, 1, 1, 1, 0;


select * from zaznam z
join ridic r on r.uid = z.uid
where r.uid = 1;



ALTER FUNCTION PoslatZpravuRidici(@uID INT) RETURNS VARCHAR(8000) AS
BEGIN
	DECLARE @vysledek VARCHAR(8000);
	DECLARE @jmeno VARCHAR(100);
	DECLARE @pocet_bodu INT;
	DECLARE @platnost_rp DATE;
	DECLARE @castka INT;
	DECLARE @odebrano_bodu INT;
	DECLARE @datum_zadani DATE;
	DECLARE @zID INT;
	DECLARE @pID INT;
	DECLARE @zamestnanec VARCHAR(100);
	DECLARE @kategorie VARCHAR(100);
	DECLARE @pocet INT;

	DECLARE @cnt INT;
	SET @cnt = 0;

	SET @pocet = (select count(*) from ridic r
	join zaznam z on z.uid = r.uid
	where r.uid = @uID)

	IF @pocet > 0
	BEGIN
		DECLARE cur CURSOR FOR
		SELECT r.Jmeno, Pocet_bodu, Platnost_RP, Castka, Odebrano_bodu, Datum_zadani, z.zID, z.pID, zam.Jmeno, t.Kategorie from Ridic r
		join Zaznam z on z.uID = r.uID
		join Zamestnanec zam on zam.zID = z.zID
		join Typ t on t.pID = z.pID
		where z.uID = @uID

		OPEN cur;
		FETCH cur INTO @jmeno, @pocet_bodu, @platnost_rp, @castka, @odebrano_bodu, @datum_zadani, @zID, @pID, @zamestnanec, @kategorie;

		SET @vysledek = 'Dobry den, zasilame Vam prehled o vasich dopravnich prestupcich.' + CHAR(10)+CHAR(13) +  'Jmeno: ' + @jmeno  
		+ CHAR(10)+CHAR(13) + 'Pocet zbyvajicich bodu: ' + CAST(@pocet_bodu AS VARCHAR) + CHAR(10)+CHAR(13)  + 'Platnost RP: ' + cast(@platnost_rp as VARCHAR)
		+ CHAR(10)+CHAR(13) +  'Seznam vasich dopravnich prestupku spolecne s jejich udaji: ' + CHAR(10)+CHAR(13);
		
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF @cnt = 0
				SET @vysledek = @vysledek + '  ' + CAST(@cnt+1 AS VARCHAR) + '. Kategorie: ' + @kategorie + ', castka: ' + 
				CAST(@castka AS VARCHAR) + ', odebrano bodu: ' + CAST(@odebrano_bodu AS VARCHAR) + ', datum zadani zaznamu: ' + 
				CAST(@datum_zadani AS VARCHAR) + ', zaznam zadan zamestnancem ID: ' + CAST(@zID AS VARCHAR) + ' - ' + @zamestnanec;
			ELSE
				SET @vysledek = @vysledek + CHAR(10)+CHAR(13) + '  ' + CAST(@cnt+1 AS VARCHAR) + '. Kategorie: ' + @kategorie + ', castka: ' + 
				CAST(@castka AS VARCHAR) + ', odebrano bodu: ' + CAST(@odebrano_bodu AS VARCHAR) + ', datum zadani zaznamu: ' + 
				CAST(@datum_zadani AS VARCHAR) + ', zaznam zadan zamestnancem ID: ' + CAST(@zID AS VARCHAR) + ' - ' + @zamestnanec;

			SET @cnt = @cnt + 1;	
			FETCH cur INTO @jmeno, @pocet_bodu, @platnost_rp, @castka, @odebrano_bodu, @datum_zadani, @zID, @pID, @zamestnanec, @kategorie;
		END;
	END;
	ELSE
		SET @vysledek = 'Dobry den, gratulujeme - nemate zadne dopravni prestupky v tomto roce'

	SET @vysledek = @vysledek + '.';
	RETURN @vysledek;
END;



BEGIN
	DECLARE @text VARCHAR(8000);
	EXEC @text = PoslatZpravuRidici 1;
	print @text;
END;

select * from ridic
select r.uid, count(z.zazID) from ridic r
left join zaznam z on z.uid = r.uid
group by r.uid
order by count(z.zazid);


insert into ridic values (22, 'Nejake jmeno', 'Ulice', 'Mesto', 'Stat', 'Obcanstvi', '1995-05-05', 15, 19498499, '2025-10-10');





ALTER PROCEDURE NovyRidic(@jmeno VARCHAR(50), @ulice VARCHAR(50), @mesto VARCHAR(50), @stat VARCHAR(50), @obcanstvi VARCHAR(50), 
@datum_narozeni DATETIME, @skupina VARCHAR(30)) AS
BEGIN
	BEGIN TRY
		DECLARE @uID INT;
		DECLARE @platnost_rp DATETIME;
		DECLARE @kID INT;
		DECLARE @cislo_rp INT;

		SET @uID = (SELECT MAX(uID) from Ridic) + 1;
		SET @platnost_rp = DATEADD(YEAR, 5, GETDATE());
		SET @kID = (SELECT kID from Skupina where skupina = @skupina);
		SET @cislo_rp = (SELECT MAX(cislo_rp) from Ridic) + 1;

		BEGIN TRANSACTION
			INSERT INTO Ridic(Jmeno, Ulice, Mesto, Stat, Obcanstvi, Datum_narozeni, Pocet_bodu, Cislo_rp, Platnost_rp) VALUES
			(@jmeno, @ulice, @mesto, @stat, @obcanstvi, @datum_narozeni, 12, @cislo_rp, @platnost_rp);
			INSERT INTO Ridicovy_skupiny(uID, kID) values (@uID, @kID);
		COMMIT;
	END TRY
	BEGIN CATCH
		ROLLBACK;
	END CATCH;
END;


EXEC NovyRidic 'Petr Mat', 'Ul', 'FM', 'CR', 'CZ', '1994-11-22', 'B';


select * from ridic r
join ridicovy_skupiny sk on sk.uid = r.uid
where r.uid = 23




select z.zID, z.jmeno, count(*) poèet from Zamestnanec z
join zaznam zaz on z.zID = zaz.zID
join Ridic r on r.uid = zaz.uid
group by z.zID, z.jmeno
order by count(*) desc;



--vstup $uID
select s.kID, skupina, popis from Skupina s
join Ridicovy_skupiny rs on rs.kID = s.kID
where uID = 1




SELECT z.zazID, Castka, Odebrano_bodu, Datum_zadani, z.zID, zam.Jmeno, t.Kategorie from Ridic r
join Zaznam z on z.uID = r.uID
join Zamestnanec zam on zam.zID = z.zID
join Typ t on t.pID = z.pID
where z.uID = 1
ORDER BY Datum_zadani desc;








select z.zID, z.Jmeno, z.Hodnost, COUNT(*) as 'Nejvíce záznamù', SUM(zaz.Castka) èástka from Zamestnanec z
join Zaznam zaz on zaz.zID = z.zID,
(
	select
	(
		select COUNT(*)
		from Zaznam zaz1
		where zaz1.zID = z1.zID
	)pocet, z1.zID, z1.Hodnost from Zamestnanec z1
)tab
where tab.zID = z.zID
group by z.Hodnost, z.Jmeno, z.zID
having MAX(tab.pocet) >= all
(
	select
	(
		select COUNT(*)
		from Zaznam zaz2
		where zaz2.zID = z2.zID
	) from Zamestnanec z2
	where z2.Hodnost = z.Hodnost
)



