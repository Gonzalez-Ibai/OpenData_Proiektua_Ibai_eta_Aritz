# OpenDataVR – Inazuma Eleven Victory Road-ko bideojokoaren pertsonaien web aplikazioa

## Proiektuaren helburua
Proiektu honen helburua **ASP.NET Core MVC erabiliz web aplikazio bat garatzea** da, Open Data iturri batetik datozen datuak erabiliz.  
Aplikazioak **Inazuma Eleven Victory Road jokoko pertsonai legendarioen informazioa** erakusten du, eta erabiltzaileari aukera ematen dio:

- Pertsonaiak **bilatzeko** (izena edo ezizenetik erabiliz)
- **Hainbat irizpideren arabera filtratzeko** (arquetipoa, posizioa, elementua eta rola)
- Datuak **zutabeen arabera ordenatzeko** (goranzkoan eta beheranzkoan)
- Datu kopuru handia dela eta, **orrialdekako bistaratzea** erabiltzeko
- **Interfaze argia eta iluna** txandakatzea

Helburua da datu asko modu eraginkor, erabilgarri eta bisualki argi batean erakustea.


---<img width="1882" height="916" alt="image" src="https://github.com/user-attachments/assets/bd2852f5-9eba-4fd9-8a14-b9aa989ae730" />


## Datuen iturria
Aplikazioak erabiltzen dituen datuak **JSON fitxategi lokal batetik** kargatzen dira.  
Fitxategi horrek Inazuma Eleven jokoetako pertsonaia legendarioen informazioa jasotzen du, besteak beste:

- Izena eta ezizena  
- Posizioa eta elementua  
- Estatistikak (potentzia, kontrola, teknika, etab.)  
- Irudiaren URLa  

Zenbait pertsonaiaren kasuan, informazioa **ez dago guztiz eskuragarri** (pertsonaia sekretuak), eta horrelakoetan aplikazioak `???` balioa erakusten du.

---

## Erabilitako teknologiak
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

## Informazioa non bilatu den
Guk Erabilitako Open data joku bateko orri batetik aterata dago. Orri honetan ez dago informazio guztia orduan excel batetik hartu ditugu datuak, Datuak csv batera bihurtu dugu eta csv-tik json-era (json erabiliz argazkiak jarri ditzazkegulako).

 
- PaginaWeb: https://zukan.inazuma.jp/en/chara_list/
- Excel: https://docs.google.com/spreadsheets/d/1m0tK8jpzDqThVLBAQsih3VAvzBNDS_d9/edit?usp=sharing&ouid=116109943142160437515&rtpof=true&sd=true

---

## Aplikazioaren funtzionamendua
Aplikazioa erabiltzeko jarraitu beharreko pausoak hauek dira:
 
1. Web aplikazioa irekitzean Home orria azaltzen da, Personajes orrian klikatzerakoan pertsonaien zerrenda agertzen da. 
2. Goiko bilatzailea erabiliz, izen edo ezizenez arabera bilatu daiteke  
3. Goitibeherako menuak erabiliz, pertsonaiak filtratu daitezke  
4. Taulako zutabeen izenetan klik eginez, datuak ordenatu daitezke  
5. Orrialdekako nabigazioa erabiliz, hurrengo edo aurreko orrialdeetara joan daiteke  
6. Goiko barran dagoen botoiarekin, **modo argia eta iluna** txandaka daitezke  


--- Aplikazioaren videoa funtzio nagusiak erakusten: https://youtu.be/_p-Z123_9PQ

## Bugak eta muga ezagunak
Une honetan **ez dugu bug larririk aurkitu**.  
Hala ere, badira kontuan hartu beharreko muga batzuk:

- Pertsonaia sekretu batzuen estatistikak ez daude eskuragarri, eta `???` gisa agertzen dira  
- Datuak JSON fitxategi lokal batetik kargatzen dira, ez datu-base batetik  

---
