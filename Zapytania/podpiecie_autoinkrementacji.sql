#Tworzenie sekwencji pod zlecenia.nr na automatyczną inkrementacje
CREATE SEQUENCE seq_nr_zlecenia
				START WITH 1
				INCREMENT BY 1;
#Podpięcie sekwencji
ALTER TABLE zlecenia 
			ALTER COLUMN nr
			SET DEFAULT nextval('seq_nr_zlecenia');
#Powiązanie na stałe sekwencji z tableą(przy isunięciu tabeli usuniemy również sekwencje)
ALTER SEQUENCE seq_nr_zlecenia OWNED BY
			zlecenia.nr;
#Teraz to samo dla klienci
CREATE SEQUENCE seq_id_klienta
				START WITH 1
				INCREMENT BY 1;
ALTER TABLE klienci 
			ALTER COLUMN id_klienta
			SET DEFAULT nextval('seq_id_klienta');
ALTER SEQUENCE seq_id_klienta OWNED BY
			klienci.id_klienta;
#Dla pracowników
CREATE SEQUENCE seq_id_pracownika
				START WITH 1
				INCREMENT BY 1;
ALTER TABLE pracownicy 
			ALTER COLUMN id_pracownika
			SET DEFAULT nextval('seq_id_pracownika');
ALTER SEQUENCE seq_id_pracownika OWNED BY
			pracownicy.id_pracownika;
#I dla tranzakcji
CREATE SEQUENCE seq_nr_tranazkcji
				START WITH 1
				INCREMENT BY 1;
ALTER TABLE tranzakcje 
			ALTER COLUMN nr_traznazkcji
			SET DEFAULT nextval('seq_nr_tranazkcji');
ALTER SEQUENCE seq_nr_tranazkcji OWNED BY
			tranzakcje.nr_traznazkcji;