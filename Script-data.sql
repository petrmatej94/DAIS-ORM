/*
SET IDENTITY_INSERT [Ridic] ON 
SET IDENTITY_INSERT [Typ] ON 
SET IDENTITY_INSERT [Zamestnanec] ON  
SET IDENTITY_INSERT [Pobocka] ON  
SET IDENTITY_INSERT [Vozidlo] ON  
SET IDENTITY_INSERT [Zaznam] ON  
SET IDENTITY_INSERT [Skupina] ON  
*/

SET DATEFORMAT dmy

SET IDENTITY_INSERT [Ridic] ON 
INSERT into [Ridic] (uID, Jmeno, Ulice, Mesto, Stat, Obcanstvi, Datum_narozeni, Pocet_bodu, Cislo_rp, Platnost_rp)
VALUES 
(1, 'Petr Mat�j', 'Uli�n� 111', 'Paskov', '�esk� Republika', '�esk�', '22.11.1994', 0, 154875, '10.6.2020'),
(2, 'Tom� Nov�', 'Ostravsk� 10', 'Fr�dek-M�stek', '�esk� Republika', '�esk�', '2.1.1993', 0, 444545, '10.10.2020'),
(3, 'Luk� Vl��il', 'Brn�nsk� 1', 'Praha', '�esk� Republika', '�esk�', '5.11.1980', 3, 546545, '5.10.2005'),
(4, 'Jana Mike�ov�', 'Pra�n� 5', 'Ostrava', '�esk� Republika', '�esk�', '5.6.1990', 3, 786786, '10.5.2010'),
(5, 'Eli�ka Obo�ilov�', 'M�steck� 55', 'Zl�n', '�esk� Republika', '�esk�', '22.1.1989', 0, 456710, '6.1.2018'),
(6, 'Dagmar Hore�kov�', 'Anensk� 11', 'Kladno', '�esk� Republika', '�esk�', '10.9.1950', 2, 567874, '10.10.2025'),
(7, 'Dalibor Nov�k', 'Anglick� 1', 'Prost�jov', '�esk� Republika', '�esk�', '5.5.1965', 0, 542470, '7.2.2024'),
(8, 'Randeep Singh', 'Arm�dn� 98', 'Brno', '�esk� Republika', 'Indick�', '21.10.1980', 1, 745767, '8.5.2021'),
(9, 'Chim Huu Dung', 'Barkhor', 'Peking', '��na', '��nsk�', '20.1.1990', 5, 754577, '2.2.2034'),
(10, 'Rajib Kumar', 'Gunlagadda', 'Dill�', 'Indie', 'Indick�', '30.3.1996', 10, 567891, '3.3.2019'),
(11, 'Bartosz Adamczyk', 'D�lnick� 12', 'Opava', '�esk� Republika', 'Polsk�', '1.1.1984', 11, 545210, '3.3.2020'),
(12, 'Juliusz Makowski', 'Miodowa 2', 'Katowice', 'Polsko', 'Polsk�', '2.10.1989', 5, 457785, '10.8.2021'),
(13, 'Dominik Grabowski', 'Stradomska 10', 'Krakow', 'Polsko', '�esk�', '14.5.1975', 0, 678945, '5.7.2022'),
(14, 'Alexandr Smetana', 'Dlouh� 954', 'Krom���', '�esk� Republika', '�esk�', '13.10.1967', 5, 451001, '15.1.2023'),
(15, 'Roman Dvo��k', 'Finsk� 54', 'T�eb��', '�esk� Republika', '�esk�', '20.6.1992', 0, 754241, '30.10.2024'),
(16, 'Petr Hor�k', 'Gaussova 1', 'Znojmo', '�esk� Republika', '�esk�', '5.5.1995', 1, 457845, '30.11.2025'),
(17, 'Marek Posp�il', 'Bassova 95', 'P�sek', '�esk� Republika', '�esk�', '24.3.1970', 0, 457888, '12.12.2025'),
(18, 'Ji�� Ku�era', 'Batelovsk� 4', 'Strakonice', '�esk� Republika', '�esk�', '28.9.1985', 0, 412475, '11.10.2026'),
(19, 'Ozzy Osbourne', 'Victoria St', 'Aston', 'Anglie', 'Anglick�', '3.12.1948', 11, 666666, '6.6.2026'),
(20, 'Iveta Vesel�', 'Walton St', 'Lond�n', 'Anglie', '�esk�', '20.10.1990', 2, 1278777, '5.5.2020'),
(21, 'Iveta Mike�ov�', 'Hlavn� t��da 5', 'Zl�n', '�esk� Republika', '�esk�', '2.2.1992', 0, 475420, '5.1.2024')
SET IDENTITY_INSERT [Ridic] OFF

SET IDENTITY_INSERT [Skupina] ON 
INSERT into [Skupina] (kID, Skupina, Popis)
VALUES 
(1, 'A', 'Motorky v�ech kategori�'),
(2, 'A1', 'Lehk� motocykly do 125 ccm a v�konu nejv��e 11 kW'),
(3, 'A2', 'Motorky s v�konem maxim�ln� 35 kW'),
(4, 'B', 'Motorov� vozidla do 3,5 tuny a maxim�ln� 8 m�st k sezen�'),
(5, 'B+E', 'Skupina B + p��pojn� vozidlo do 3,5 tuny'),
(6, 'B1', 'T��kolov� a �ty�kolov� vozidla'),
(7, 'C', 'Motorov� vozidla p�evy�uj�c� 3,5 tuny a v�ce ne� 8 m�st k sezen�'),
(8, 'C+E', 'Skupina C + p��pojn� vozidlo'),
(9, 'D', 'Vozidla pro p�epravu osob s v�ce ne� 8 m�sty k sezen�'),
(10, 'D+E', 'Skupina D + p��pojn� vozidlo'),
(11, 'D1', 'Vozidla pro p�epravu osob v v�ce ne� 8 m�sty, ale m�n� ne� 16 m�sty k sezen�'),
(12, 'D1+E', 'Skupina D1 + p��pojn� vozidlo'),
(13, 'T', 'Traktory a pracovn� stroje i s p��pojn�m vozidlem')
SET IDENTITY_INSERT [Skupina] OFF


SET IDENTITY_INSERT [Typ] ON
INSERT into [Typ] (pID, Kategorie, Popis, Maximalni_vyse, Bodovy_trest)
VALUES 
(1, 'Jizda na cervenou', '', 2000, 2),
(2, 'Nedani prednosti v jizde', '', 3000, 1),
(3, 'Parkovani', 'St�n� na nevyzna�en�m m�st�, st�n� na m�st� vyhrazen�m pro invalidy', 300, 0),
(4, 'Rizeni bez dokladu', '', 1000, 1),
(5, 'Rizeni pod vlivem omamnych latek', '', 20000, 3),
(6, 'Rychlost', 'P�ekro�en� rychlosti o 30km/h', 10000, 2),
(7, 'Spatny stav vozidla', '��zen� vozidla, kter� je technicky nezp�sobil� k provozu na pozemn�ch komunikac�ch tak z�va�n�m zp�sobem, �e bezprost�edn� ohro�uje ostatn� ��astn�ky provozu na pozemn�ch komunikac�ch', 10000, 5),
(8, 'Telefonovani za jizdy', '', 2000, 1)
SET IDENTITY_INSERT [Typ] OFF


SET IDENTITY_INSERT [Pobocka] ON 
INSERT into [Pobocka] (pobID, Ulice, Mesto, Stat, Typ)
VALUES 
(1, 'Radni�n� 5', 'Ostrava', '�esk� Republika', 'Krajske'),
(2, 'Hlavn� t��da 10', 'Fr�dek-M�stek', '�esk� Republika', 'Obvodni'),
(3, 'Ostravsk� 10', 'Ostrava', '�esk� Republika', 'Reditelstvi'),
(4, 'U Parku 55', 'Praha', '�esk� Republika', 'Reditelstvi'),
(5, 'Obo�ilova 6', 'Praha', '�esk� Republika', 'Obvodni'),
(6, 'Komensk�ho 13', 'Praha', '�esk� Republika', 'Mistni'),
(7, 'Fr�dlantsk� 62', 'Ostrava', '�esk� Republika', 'Mistni'),
(8, 'Jan��kova 955', 'Ostrava', '�esk� Republika', 'Obvodni')
SET IDENTITY_INSERT [Pobocka] OFF


SET IDENTITY_INSERT [Vozidlo] ON 
INSERT into [Vozidlo] (vID, VIN, SPZ, Znacka, Model, Typ, Barva, uID)
VALUES 
(1, 'HDF484DF451D2FD33F', '3G5 4784', '�koda', 'Octavia', 'Osobn� automobil', 'Modr�', 1),
(2, 'DF1Q9K4J4H12HGH1G2', '6Q3 5478', 'Nissan', 'Navara', 'Ter�nn� automobil', '�erven�', 1),
(3, 'WEER4H411V3VG44FG4', '6N9 3715', 'Iveco', 'Crossway', 'Autobus', '�ern�', 2),
(4, 'V1C3S6D5F4W8ER4GGG', '0N0 7845', 'Toyota', 'Yaris', 'Osobn� automobil', '�lut�', 3),
(5, 'W9E8RE4DF4DF6S4F6D', '3AQ 0142', 'BMW', 'x5', 'Ter�nn� automobil', 'Modr�', 4),
(6, 'PO1PU4I81Z2H1G3H6F', '5V0 5555', '�koda', 'Superb', 'Osobn� automobil', '�erven�', 5),
(7, 'C9EWRQQ113C4GSDDDF', '4A4 0124', '�koda', 'Octavia', 'Osobn� automobil', '�lut�', 6),
(8, 'R9G11V41FG4GG4F8G4', '9V9 6789', 'Iveco', 'Crossway', 'Autobus', 'Modr�', 6),
(9, 'WER7EWREWR4WER4G1G', '3B5 6124', '�koda', 'Yati', 'Ter�nn� automobil', '�lut�', 6),
(10, '1NN1B1V65BVB10VBV', '1B4 4575', 'Suzuki', 'V-Strom', 'Motorka', '�ern�', 7),
(12, 'WE9R8T4D1WQ1D1F4F', '3N1 1234', 'Harley Davidson', 'Street Rod 750', 'Motorka', '�erven�', 8),
(13, 'DF5W9E4T8DG4DSFD4S', '6F5 4573', '�koda', 'Kodiaq', 'Ter�nn� automobil', '�erven�', 9),
(14, 'FDF1FC2B15D4FSDF4S', '8Q7 1345', 'Harley Davidson', 'Street Rod 500', 'Motorka', 'Modr�', 10),
(15, 'QWERTZRRTR48451DFF', '3F9 3214', 'Zetor', '', 'Zem�d�lsk� a lesnick� stroje', 'Modr�', 15),
(16, 'POIUZTRF51GDF1555D', '9E8 3697', '�koda', 'Karoq', 'Ter�nn� automobil', '�ern�', 11),
(17, 'MN1BVCD5G15G151FG5', '9QW 6754', '�koda', 'Octavia', 'Osobn� automobil', '�erven�', 13),
(18, 'PLMTREWDFB474G48F8', '6S6 6666', 'Ford', 'Mustang', 'Osobn� automobil', '�ern�', 19)
SET IDENTITY_INSERT [Vozidlo] OFF



INSERT into [Ridicovy_skupiny] (uID, kID)
VALUES 
(1, 4),
(1, 2),
(2, 3),
(2, 4),
(2, 6),
(3, 4),
(4, 4),
(5, 4),
(6, 4),
(6, 5),
(6, 7),
(7, 9),
(9, 8),
(8, 2),
(8, 4),
(10, 4),
(11, 4),
(12, 4),
(13, 4),
(14, 4),
(15, 4),
(16, 4),
(17, 4),
(18, 4),
(19, 4),
(20, 4),
(19, 6),
(18, 8),
(17, 10),
(16, 13),
(14, 13),
(10, 8),
(18, 1),
(15, 2),
(13, 2),
(13, 1),
(13, 5),
(13, 6),
(13, 7),
(13, 8),
(13, 9),
(14, 8),
(16, 11),
(8, 12),
(6, 13)


SET IDENTITY_INSERT [Zamestnanec] ON 
INSERT into [Zamestnanec] (zID, Jmeno, Hodnost, pobID)
VALUES 
(1, 'Franti�ek Svoboda', 'Dustojnik', 8),
(2, 'Petr M��el', 'Praporcik', 7),
(3, 'Dalibor Zeman', 'Praporcik', 6),
(4, 'Marek Va�ut', 'Praporcik', 5),
(5, 'Karel Sedl��ek', 'Praporcik', 4),
(6, 'Jan Pokorn�', 'General', 3),
(7, 'Dominik Ku�era', 'Praporcik', 2),
(8, 'Luk� Proch�zka', 'Praporcik', 1),
(9, 'Jan Kr�l', 'Dustojnik', 2),
(10, 'David H�jek', 'Dustojnik', 3),
(11, 'Tom� Dole�al', 'Praporcik', 4),
(12, 'Petr Sedl��ek', 'Dustojnik', 5),
(13, 'Marek Jel�nek', 'Praporcik', 6),
(14, 'Vlastimil �ern�', 'Praporcik', 7),
(15, 'V�clav Novotn�', 'Praporcik', 8),
(16, 'David Nov�k', 'Dustojnik', 1),
(17, 'V�clav Hor�k', 'Praporcik', 3),
(18, 'Luk� Posp�il', 'Praporcik', 3),
(19, 'Jan Kol��', 'Dustojnik', 3),
(20, 'Dominik Kopeck�', 'General', 4),
(21, 'Jan Musil', 'Dustojnik', 4),
(22, 'Vlastimil Pol�k', 'Dustojnik', 4)
SET IDENTITY_INSERT [Zamestnanec] OFF


SET IDENTITY_INSERT [Zaznam] ON 
INSERT into [Zaznam] (zazID, Castka, Odebrano_bodu, Datum_zadani, Datum_expirace, Datum_provedeni, uID, zID, pID)
VALUES 
(1, 1000, 1, '10.10.2015', '10.11.2015', '15.10.2015', 1, 22, 8),
(2, 5000, 5, '5.10.2016', '5.11.2016', '10.10.2016', 2, 21, 7),
(3, 2000, 2, '1.5.2017', '1.6.2017', NULL, 3, 20, 6),
(4, 300, 0, '1.1.2016', '1.2.2016', '20.1.2016', 4, 20, 5),
(5, 100, 0, '3.8.2015', '3.9.2015', '10.8.2015', 5, 5, 4),
(6, 10000, 3, '20.10.2017', '20.11.2017', '30.10.2017', 5, 4, 3),
(7, 5000, 2, '6.2.2016', '6.3.2016', '20.2.2016', 5, 3, 1),
(8, 800, 0, '2.7.2015', '2.8.2015', NULL, 6, 2, 1),
(9, 7000, 3, '10.3.2015', '10.4.2015', '20.3.2015', 7, 1, 1),
(10, 400, 0, '2.2.2017', '2.3.2017', '20.2.2017', 3, 10, 6),
(11, 1000, 1, '7.7.2017', '7.8.2017', NULL, 10, 14, 6),
(12, 2000, 1, '6.5.2015', '6.6.2015', '26.5.2015', 8, 15, 6),
(13, 3000, 2, '20.12.2015', '20.1.2015', NULL, 15, 16, 6),
(14, 4000, 3, '1.12.2017', '1.1.2017', '20.12.2017', 16, 17, 6),
(15, 7000, 3, '10.10.2015', '10.11.2015', '20.10.2015', 17, 5, 3),
(16, 20000, 5, '8.5.2015', '8.6.2015', NULL, 18, 6, 7),
(17, 50000, 7, '20.2.2017', '20.3.2017', NULL, 19, 7, 6),
(18, 40000, 6, '6.6.2017', '6.7.2017', NULL, 20, 3, 7),
(19, 200, 0, '15.10.2017', '15.11.2017', '25.10.2017', 14, 2, 3),
(20, 5000, 2, '7.7.2016', '7.8.2016', '25.7.2016', 10, 1, 4),
(21, 6000, 2, '7.5.2016', '7.6.2016', '10.5.2016', 10, 1, 4),
(22, 300, 0, '1.5.2016', '1.6.2016', '10.5.2016', 8, 2, 3),
(23, 500, 0, '14.5.2016', '14.6.2016', '20.5.2016', 4, 2, 3),
(24, 100, 0, '4.5.2016', '4.6.2016', '10.5.2016', 21, 1, 1)
SET IDENTITY_INSERT [Zaznam] OFF