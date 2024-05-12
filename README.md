# mobiilid
2024 kevad TLÜ Mobiilirakenduste arendamise kursus
Grupp 6 - Unity Hub

Autorid: 
Karl Otepalu
Annabel Väljaots
Isabella Pebsen
Katriin Liselle Eenmaa
Annika Rohtmets
Merette Arula

Projekti idee:
Lihtne ja lõbus jalgpalli-teemaline mäng, kus mängija peab ekraanile vajutades või seadet kallutades jalgpalli paremale või vasakule liigutama, et vältida vastu tulevatele jalgpalluritele (takistustele) pihta minemist.


Tech stack: 
Unity 2023.2.18f1 (C#); 
Krita;
Photopea;
Flaticon

Paigaldus:

Lae alla Unity 2022.3.18 (kaasa arvatud Android moodulid: Android Build Support, Android SDK & NDK, ToolsOpenJDK) ja Unity Hub.
Klooni antud githubi repository.
Ava Unity Hubis projekt vajutades “Add”. Leia ülesse kloonitud repository ning vali terve kaust. Seejärel vajutage open. Projekt avatakse “Editor” vaates”
Vali "Project" vahelehe pealt "Assets" -> "Scenes". 
Mängus on 4 stseeni:
Main on põhilise menüü vaade, kust saab valida 2 erineva mänguviisi vahel.
Game on tavamäng, kus saab paremale ja vasakule vajutustega liikuda takistuste eest ära. 
GameTilt on kallutamise mäng, kus saab telefoni kallutades paremale ja vasakule liikuda takistuste eest ära. 
GameOver on vaade, mis kuvatakse, kui mängija takistusega kokku põrkab ning mäng läbi saab. Seal saab valida, kas minna tagasi põhimenüü vaatesse ja mängida teist mängutüüpi või mängida sama mängutüüpi uuesti.	
Vali stseen mida soovid parasjagu katsetada. Kui soovid mängu algusest mängida, siis vali Main stseen (tee sellel topelt klikk).
Vajuta ülevalt "Play"
![](https://github.com/KOtepalu/mobiilid/blob/main/image_1.PNG)
Head mängimist!

Kuidas telefonis käivitada:
Lae alla Unity 2022.3.18 (kaasa arvatud Android moodulid: Android Build Support, Android SDK & NDK, ToolsOpenJDK) ja Unity Hub.
Klooni antud github’i repository
Unitys projekti avades tuleb minna “File” -> “Build Settings” ning tuleb veenduda et platvorm oleks “Android”. Kui see pole, siis tuleb valida “Android” ning seejärel vasakul nurgas minna “Player settings” -> “Editor” ning vaadata, et esimesel real “Device” oleks “Any Android Device”
![](https://github.com/KOtepalu/mobiilid/blob/main/image_2.PNG)
![](https://github.com/KOtepalu/mobiilid/blob/main/image_3.PNG)

Seejärel tuleb minna “Edit” -> “Preferences” ning kontrollida kas “Android” all on nii “Android SDK Tools”, “JDK” kui ka “Android NDK” installitud. Kui on õigesti, siis on näha mõlema ees väike linnuke.
![](https://github.com/KOtepalu/mobiilid/blob/main/image_4.PNG)
        Kui ei seda ei ole, siis tuleb minna Unity Hubi ning valida “Installs”. Seejärel on näha valitud versioon Unity’st,          tuleb klikkida Settingute ikoonil, valida “Add modules” ja siis alla laadida moodulid “Android Build Support”,               “Android SDK & NDK Tools” kui ka “OpenJDK”.
        ![](https://github.com/KOtepalu/mobiilid/blob/main/image_5.PNG)
        ![](https://github.com/KOtepalu/mobiilid/blob/main/image_6.PNG)


Selleks, et android telefonis koodi katsetada laadida alla app “Unity Remote 5”
Telefonis otsi Seadistustest (Settings) ülesse oma telefoni järgu number (build number) - see on tavaliselt leitav “Teave telefoni kohta” all. Järgu numbril kliki 7 korda, et tuua Arendaja valikud (Developer options) nähtavale
Ava Arendaja valikud (Developer options) ning luba USB silumine (USB debugging)
Nüüd kui ühendada telefon USB-ga arvuti külge, siis tavaliselt telefon küsib uuesti, kas lubada USB silumine (USB debugging). Sellele tuleks vastata “Luba”
Ava telefonis Unity Remote 5 ja käivita arvutist Unitys mäng (vajutades Stseeni käivitamise nuppu kõige üleval). Mäng peaks nüüd telefonis tööle hakkama
![](https://github.com/KOtepalu/mobiilid/blob/main/image_7.PNG)
      Kui mäng telefonis tööle ei hakka, siis proovi arvutis sulgeda ja avada Unity ning proovi uuesti. Teine variant on           proovida USB korraks lahti ühendada ja uuesti käima panna. 


Mis oli raske: 
taustapildi asetamine elementide taha;
skooride kuvamine peale mängu lõppu;
errorite ja bugide lahendamine;
Unity’l suhteliselt suur õppimiskõver;
Skriptide kirjutamine

Mis oli kerge:
internetis oli palju infot, abi ja õpetusi Unity kohta leida;
UI elementide loomine;
tiimitöö oli väga sujuv ja hea;
disaini väljamõtlemine ja selle teostamine;
stseenide vahetamine SceneManager’iga


Mäng

![](https://github.com/KOtepalu/mobiilid/blob/main/image_8.PNG)
![](https://github.com/KOtepalu/mobiilid/blob/main/image_9.PNG)


Skriptid:
Block.cs – kustutab takistuse, kui see on väljunud mänguväljast ning lisab skoorile 1 punkti
GameManager.cs – kui vajutatakse ekraanile alustab mängu ja kutsub esile takistuste kukkumise ning määrab, mis positsioonil takistused kukuvad
GameOver.cs – määrab, millisele mängule (Game või GameTilt) minna kui vajutatakse “Try again” nuppu, saadab mängija tagasi “Main” vaatesse kui vajutatakse “Home” nuppu
MainMenu.cs - määrab millist mängu alustatakse, kas “Game” või “GameTilt”, kui vajutatakse “Quit” nuppu väljub rakendusest
Player.cs – liigutab mängijat vastavalt ekraani puudutusele, kas vasakule või paremale, kui mängija puutub kokku takistusega, siis lõpetab mängu ja liigub uuele stseenile “GameOver”
PlayerTilt.cs – liigutab mängijat vastavalt kallutusele, kas vasakule või paremale, kui mängija puutub kokku takistusega, siis lõpetab mängu ja liigub uuele stseenile “GameOver”
ScoreManager.cs – esimesel korral uuel seadmel mängides salvestab saadud skoori  ka high score’ina, uuesti mängides salvestab skoori, kui see on parem kui senine kõrgeim tulemus uuendab high score, kutsub esile score ja high score näitamise mängu ajal ning nende uuendamise

Mängu mobiili kuvatõmmised:
![](https://github.com/KOtepalu/mobiilid/blob/main/Mobiilikuvatommis.jpg | width=50)
![](https://github.com/KOtepalu/mobiilid/blob/main/Mobiilikuvatommis1.jpg | width=50)
![](https://github.com/KOtepalu/mobiilid/blob/main/Mobiilikuvatommis2.jpg | width=50)
![](https://github.com/KOtepalu/mobiilid/blob/main/Mobiilikuvatommis3.jpg | width=50)


