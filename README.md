# 📌 OpenDataVR – Inazuma Eleven Victory Road-ko bideojokoaren pertsonaien web aplikazioa

## 🎯 Proiektuaren helburua
Proiektu honen helburua **ASP.NET Core MVC erabiliz web aplikazio bat garatzea** da, Open Data iturri batetik datozen datuak erabiliz.  
Aplikazioak **Inazuma Eleven Victory Road jokoko pertsonai legendarioen informazioa** erakusten du, eta erabiltzaileari aukera ematen dio:

- Pertsonaiak **bilatzeko** (izena edo ezizenetik erabiliz)
- **Hainbat irizpideren arabera filtratzeko** (arquetipoa, posizioa, elementua eta rola)
- Datuak **zutabeen arabera ordenatzeko** (goranzkoan eta beheranzkoan)
- Datu kopuru handia dela eta, **orrialdekako bistaratzea** erabiltzeko
- **Interfaze argia eta iluna** txandakatzea

Helburua da datu asko modu eraginkor, erabilgarri eta bisualki argi batean erakustea.

📸 HEMEN APLIKAZIOAREN SCREENSHOT OROKOR BAT SARTU

---

## 📊 Datuen iturria
Aplikazioak erabiltzen dituen datuak **JSON fitxategi lokal batetik** kargatzen dira.  
Fitxategi horrek Inazuma Eleven jokoetako pertsonaia legendarioen informazioa jasotzen du, besteak beste:

- Izena eta ezizena  
- Posizioa eta elementua  
- Estatistikak (potentzia, kontrola, teknika, etab.)  
- Irudiaren URLa  

Zenbait pertsonaiaren kasuan, informazioa **ez dago guztiz eskuragarri** (pertsonaia sekretuak), eta horrelakoetan aplikazioak `???` balioa erakusten du.

📸 HEMEN DATUEN ADIBIDEAREN SCREENSHOT BAT (JSON edo taularen ikuspegia)

---

## 🛠️ Erabilitako teknologiak
Proiektua garatzeko honako teknologiak erabili dira:

- **C#** – Programazio-lengoaia nagusia  
- **ASP.NET Core MVC** – Web aplikazioaren arkitektura  
- **Razor Views** – HTML eta C# konbinatzeko  
- **Bootstrap 5** – Diseinu erantzunkorra eta estiloak  
- **JavaScript** – Interakzioak eta gai argi/iluna kudeatzeko  
- **JSON** – Datuen biltegiratzea  
- **Visual Studio 2022** – Garapen-ingurunea  
- **Git / GitHub** – Bertsioen kontrola  

---

## 📚 Informazioa non bilatu den
(ATAL HAU HUTSIK UTZI NAHITA)

- 
- 
- 

---

## 🧪 Aplikazioaren funtzionamendua
Aplikazioa erabiltzeko jarraitu beharreko pausoak hauek dira:

1. Web aplikazioa irekitzean Home orria azaltzen da, Personajes orrian klikatzerakoan pertsonaien zerrenda agertzen da. 
2. Goiko bilatzailea erabiliz, izen edo ezizenez arabera bilatu daiteke  
3. Goitibeherako menuak erabiliz, pertsonaiak filtratu daitezke  
4. Taulako zutabeen izenetan klik eginez, datuak ordenatu daitezke  
5. Orrialdekako nabigazioa erabiliz, hurrengo edo aurreko orrialdeetara joan daiteke  
6. Goiko barran dagoen botoiarekin, **modo argia eta iluna** txandaka daitezke  

🎥 HEMEN APLIKAZIOAREN ERABILERA BIDEOAREN ESTEKA (YouTube edo GIF)

---

## 🐞 Bugak eta muga ezagunak
Une honetan **ez da bug larririk aurkitu**.  
Hala ere, badira kontuan hartu beharreko muga batzuk:

- Pertsonaia sekretu batzuen estatistikak ez daude eskuragarri, eta `???` gisa agertzen dira  
- Datuak JSON fitxategi lokal batetik kargatzen dira, ez datu-base batetik  

---
