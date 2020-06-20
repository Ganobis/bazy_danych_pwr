#Tworznie tabeli zlecenia
CREATE TABLE zlecenia (nr INT PRIMARY KEY UNIQUE NOT NULL, 
						towar CHAR NOT NULL, 
						cel CHAR NOT NULL, 
						pochodzenie CHAR NOT NULL,
						termin DATE NOT NULL,
						rejestracha_samochodu CHAR NOT NULL,
						specialne_warunki CHAR,
						id_pracownika INT NOT NULL,
						id_klienta INT NOT NULL,
						id_kontenera INT NOT NULL);
#Tworzenie tabeli klienci
CREATE TABLE klienci (id_klienta INT PRIMARY KEY UNIQUE NOT NULL,
						imie CHAR NOT NULL,
						nazwisko CHAR NOT NULL,
						telefon INT,
						pesel INT UNIQUE NOT NULL,
						dodatkowe_informacje CHAR);
#Tworzneie tablei samochody
CREATE TABLE samochody (rejestracja CHAR PRIMARY KEY UNIQUE NOT NULL,
						rodzaj CHAR,
						rok_produkcji INT NOT NULL,
						data_ubezpieczenia DATE,
						data_przegladu DATE);
#Tworzenie tabeli kontenery
CREATE TABLE kontenery (id INT PRIMARY KEY UNIQUE NOT NULL,
						pojemnosc FLOAT(8),
						data_przegladu DATE);
#Tworzenie tablei wyplaty
CREATE TABLE wyplaty (id_pracownika INT NOT NULL,
					  data DATE NOT NULL,
					  pensja FLOAT(8) NOT NULL,
					  premia FLOAT(8));
#