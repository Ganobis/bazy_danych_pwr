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
#Tworzenie tabeli pracownicy
CREATE TABLE wyplaty (id_pracownika INT PRIMARY KEY UNIQUE NOT NULL,
					  imie CHAR(50) NOT NULL,
					  nazwisko CHAR(50) NOT NULL,
					  pesel CHAR(11) NOT NULL.
					  nr_konta CHAR(26) NOT NULL,
					  miejsce_zamieszkania CHAR(70) NOT NULL,
					  telefon CHAR(9) NOT NULL,
					  data_zatrudnienia DATE NOT NULL,
					  data_konca_umowy DATE,
					  stanowiska CHAR(50) NOT NULL);
#Tworzenie tabeli tranzakcje
CREATE TABLE tranzakcje (nr_traznazkcji INT PRIMARY KEY UNIQUE NOT NULL,
						uznania INT,
						kwota REAL NOT NULL);