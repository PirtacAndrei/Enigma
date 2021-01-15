
<h1>Enigma</h1>


<h1>Introducere</h1>


<p>
Proiectul a fost realizat folosind Unity Engine si un <a href="https://sketchfab.com/3d-models/enigma-machine-1934-c8ee76c383654e3095ea4cc9e7990274">3d model</a> realizat de către <strong><a href="https://sketchfab.com/sciencemuseum">Science Museum Group.</a></strong> Scopul acestui proiect este simularea unei mașini de criptare Enigma cu patru rotoare, dintre care un reflector, si zece mufe. Un utilizator poate sa modifice setarile de criptare (rotoare si mufe) si sa introduca text folosind tastatura fizica ca mai apoi sa vizualizeze cum textul s-a modificat prin procesul de criptare.
</p>
<p>
Acest program a fost realizat de Pirtac Andrei-Marius.
</p>
<h1>Interfata</h1>


<h2>General</h2>


<p>
La deschiderea programului apare meniul de tutorial in care sunt prezentate butoanele din program si care poate sa fie închis din stanga sus folosind butonul “X”.
</p>
<p>
In acest program sunt folosite următoarele butoane:
</p>
<ul>

<li>X : pentru a închide un meniu deschis

<li>O : pentru a deschide un meniu 

<li>? : tutorial

<li>Exit : dreapta sus, inchide aplicatia

<li>X RESET ALL : șterge toate setarile introduse la categoria mufe
</li>
</ul>
<h2>Tastatura</h2>


<p>
Pe modelul 3d se pot observa cerculete cu litere in ele deasupra tastaturii. Aceste cerculete sunt reprezentative pentru becurile care se aprind pentru a arata litera criptată. 
</p>
<p>
La apasarea unei litere de pe tastatura fizica un bec se va “aprinde”, ca mai apoi sa se stinga cand tasta este in pozitia normala (ridicata).
</p>
<h2>Foaie pentru input si output</h2>


<p>
 
</p>
<p>
In dreapta se poate observa o foaie goala cu un buton “O” deasupra ei. Acest buton deschide meniul de vizualizare pentru mesajul introdus de la tastatura fizica împreuna cu varianta lui criptată.
</p>
<h2>Rotoare</h2>


<p>
Deasupra tastaturii și beculetelor se afla un buton “O” care deschide meniul pentru rotoare. În acest meniu utilizatorul poate sa vizualizeze schimbarea rotoarelor si sa le modifice pozitia. 
</p>
<p>
Programul o sa initializeze rotoarele cu valoarea 1.
</p>
<p>
Cum se poate observa în figura de mai jos, se pot schimba valorile pentru trei rotoare din patru pentru ca unul dintre ele este un reflector (vezi reflector); valoarea din dreapta este pentru primul rotor, cea din mijloc pentru al doilea și cea din stanga pentru al treilea rotor.
</p>
<p>
 
</p>
<h2>Mufe</h2>


<p>
Sub tastatura se afla un buton “O” care deschide meniul pentru mufe unde un utilizator poate sa vadă și sa modifice mufele. În acest meniu sunt prezente zece perechi de cate doua casete de input. În fiecare casuta se poate adaugă o litera care mai apoi sa fie legate la alta litera (perechea ei). O astfel de pereche este o coloana, doua casute una peste alta. Acest meniu contine și un buton pentru resetarea valorilor. Cat timp acest meniu este deschis inputul de la tastatura fizica nu este citit pentru criptare.
</p>
<p>
Mufele sunt opționale si sunt inițializate cu “ “, astfel nu exista perechi la deschiderea programului.
</p>
<h2>Tutorial</h2>


<p>
In interfata de tutorial utilizatorul poate sa citeasca ce reprezinta fiecare buton de tipul “O”, cum funcționează masina si cum se decripteaza mesajele. De asemenea este prezent și un exemplu de decriptare in care utilizatorul primește mesajul “HFAWCJ” cu setarile 20|10|5 si AB DF OY JQ MN. Decriptarea ar trebui sa rezulte in mesajul “POTATO”.
</p>
<h2>Exit</h2>


<p>
In colțul din dreapta sus se afla butonul care închide aplicația.
</p>
<h1>Mod de utilizare</h1>


<h2>Deschidere</h2>


<p>
Este recomandat ca la prima deschidere a programului utilizatorul sa citeasca meniul de tutorial.
</p>
<p>
Pentru a incepe criptarea unui mesaj utilizatorul trebuie sa inchida meniul de tutorial folosing butonul “X” din coltul din stanga sus. 
</p>
<p>
Dupa inchiderea acestui meniu se poate incepe introducerea de la tastatura fizica a unui mesaj care va fi criptat cu setarile initiale si care poate sa fie vizualizat folosind 

<a href="#heading=h.c69pl8i5ejqj">meniul pentru input si output (foaia).</a>
</p>
<h2>Rotoare</h2>


<p>
Pentru a schimba valoarea unui rotor se va selecta textul din 

<a href="#heading=h.jvestq3aeup8">casuta de input</a> pentru acel rotor si se va modifica cu un numar cuprins intre 1 si 26 (inclusiv). 
</p>
<p>
Pentru a modifica un rotor utilizatorul trebuie sa modifice si rotoarele care urmeaza dupa cel modificat. 
</p>
<p>
Exemple pentru modificarea rotoarelor:
</p>
<ol>

<li>Inițial rotoarele au valorile 1|3|7. Utilizatorul dorește sa modifice valoarea primului rotor din 7 in 1. După aceasta modificare rotoarele o sa arate asa 1|3|1. Deși utilizatorul a schimbat valoarea rotorului cum a planuit, acesta trebuie sa modifice si valoarea rotorului doi din 3 in 3 si apoi rotorului trei din 1 in 1, la final avand tot 1|3|1. 

<li> Inițial rotoarele au valorile 2|24|1. Utilizatorul dorește sa modifice valoarea rotorului doi  din 24 în 3. După aceasta modificare rotoarele o sa arate asa 2|3|1. Deși utilizatorul a schimbat valoarea rotorului cum a plănuit, acesta trebuie sa modifice și valoarea rotorului trei din 2 in 2, dar nu trebuie sa modifice și pentru rotorul unul, pentru ca acesta se afla în spatele rotorului modificat.
</li>
</ol>
<p>
Dacă utilizatorul dorește sa modifice toate rotoarele acestea trebuie modificate in ordine crescătoare, primul rotor, al doilea si apoi al treilea.
</p>
<p>
Cum se poate observa in exemple, deși utilizatorul nu doreste sa modifice valoarea rotorului trei, aceasta trebuie modificata pentru ca după modificarea rotorului doi se executa un cerc complet de rotiri care o sa schimbe implicit si valoarea rotorului trei (

<a href="#heading=h.of0nkl96sc5n">vezi constructia rotoarelor</a>). 
</p>
<p>
Meniul cu valorile rotoarelor poate sa ramana deschis in timpul introducerii literelor pentru criptare, astfel se observa cum la fiecare input nou valorile se schimba cu +1.
</p>
<h2>Mufe</h2>


<p>
Dupa deschiderea 

<a href="#heading=h.n75irw5n8e9t">meniului de mufe</a> inputul de la tastatura fizica nu o sa mai fie citit pentru criptare, acest lucru fiind datorat faptului ca programul se asteapta ca utilizatorul sa modifice mufele folosind un input de tipul litera, care este de asemenea folosit in mod normal pentru criptare.
</p>
<p>
In acest meniu se pot modifica casutele goale, in fiecare fiind acceptata o litera care nu este deja intr-o pereche. Daca inputul introdus intr-o casuta este un text care cuprinde mai multe litere sau o litera deja intr-o pereche sau aceeasi litera ca perechea ei, casuta pentru aceasta litera o sa se goleasca impreuna cu casuta pentru pereche.
</p>
<p>
Dupa modificarea acestor casute, pentru schimbarea lor in alte valori trebuie folosit butonul “RESET ALL” pentru ca valorile de conexiuni sa se reseteze.
</p>
<p>
Nu este permisa introducerea unui numar sau simbol special.
</p>
<p>
Dupa ce utilizatorul termina de facut modificarile, pentru a reincepe criptarea unui text, trebuie sa inchida acest meniu.
</p>
<h1>Mecanismul</h1>


<h2>Introducere</h2>


<p>
Masina fizica enigma folosea cabluri care se conectau intr-un mod complex de la o litera de pe tastatura la un bec cu simbolul unei litere. Cand tasta era apasata circuitul era pornit si curentul aprindea un bec, astfel apasand o tasta era “returnata” o alta litera care era valoarea criptata pentru tasta apasata.
</p>
<p>
Procesul de criptare urmeaza acesti pasi:
</p>
<ol>

<li>Se apsa o tasta

<li>Curentul ajunge la mufe unde daca este conectata o mufa litera introdusa se transforma in litera cu care este conectata

<li>Curentul trece mai departe la rotoare unde intra cu valoarea precedenta. Aici fiecare litera este conectata la alta litera printr-un cablu, si astfel valoarea precedenta trece mai departe in rotorul urmator folosind noua valoarea la care este legata.

<li>In al doilea rotor se repeta procus, litera precedenta trece print-o conexiune in alta litera si este transmisa mai departe

<li>In al treilea rotor se repeta identic cu al doilea rotor.

<li>In ultimul rotor numit si reflector valorile sunt conectate una la alta, circuitul este astfel intors invers.

<li>Se intra in al treilea rotor cu valoarea obtinuta din reflector si se trece prin proces dar in mod invers.

<li>Se repeta pasul 7 prin rotoarele doi si unu

<li>Dupa ce valoarea iese din rotoare aceasta se intoarce la mufe unde, daca este conectata la ceva, se transforma in valoarea la care este conectata

<li>Dupa tot circuitul se ajunge la bec care se aprinde in functie de ce valoarea este la final.
</li>
</ol>
<p>

    In continuare vor fi prezentate componentele in mod individual.
</p>
<h2>Mufe </h2>


<p>
 Aceasta este prima componenta prin care trece litera introdusa.
</p>
<p>

<img src="images/image1.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
In cazul pozei de mai sus litera A este conectata cu litera J; si litera S este conectata cu litera O.
</p>
<p>
Daca presupunem ca am incepe criptarea literei A folosind aceasta masina, atunci la acest pas am transforma A in J. 
</p>
<p>
Daca in schimb am presupune ca am incepe cu litera Q, la acest pas nu am face nimic pentru ca nu exista o legatura intre Q si alta litera.
</p>
<p>
Aceasta componenta este doar o schimbare evidenta, dar care adauga extrem de multe optiuni in setarile de decriptare si implicit de criptare.
</p>
<h2>Rotoare</h2>


<p>
Aceste componente constituie partea complexa de criptare. In poza de deasupra se poate observa cum arata un astfel de rotor. 
</p>
<p>
Fiecare rotor are lista alfabetica de litere (ABCD...Z) si o lista cu conexiuni (FTG...K). Exista multe rotoare folosite in masinile enigma, acestea au fost schimbat destul de des pentru a schimba complet ce output poti sa primesti si au fost de asemenea folosite pe diverse domenii, spre exemplu aviatia folosea alte combinatii decat trupele de sol.
</p>
<p>
Rotoarele folosite in acest program sunt urmatoarele: 
</p>
<p>
Rotorul unu <code>PEZUOHXSCVFMTBGLRINQJWAYDK</code>
</p>
<p>
Rotorul doi  <code>ZOUESYDKFWPCIQXHMVBLGNJRAT</code>
</p>
<p>
Rotorul trei  <code>EHRVXGAOBQUSIMZFLYNWKTPDJC</code>
</p>
<p>
Reflector     <code>IMETCGFRAYSQBZXWLHKDVUPOJN</code>
</p>
<p>
Aceste rotoare au fost folosite in 1939.
</p>
<p>
Dupa ce o litera a fost criptata primul rotor (cel din dreapta) se invarte cu o iteratie. Dupa valoarea 26 se intoarce la 1 si se invarte urmatorul rotor (cel din mijloc). Astfel daca ai vrea sa modifici primul rotor de la valoarea 2 la 1 trebuie sa faci un cerc complet si o sa modifici si valoarea rotorului doi. Pentru ca nu voiai sa modifici valoarea rotorului doi sa spunem ca din 3 in 4 cat a ajuns sa fie dupa ce primul rotor a fost modificat, trebuie sa il modifici si pe acesta cu o rotatie completa ca sa ajungi inapoi la 3, si astfel modifici si ultimul rotor fara sa vrei. Programul folosește același principiu, din acest motiv modificarea rotoarelor trebuie facuta de la dreapta la stanga și completa.
</p>
<p>
Mai departe va fi prezentat modul de funcționare printr-o reprezentare grafica exemplificativa.
</p>
<p>

<img src="https://docs.google.com/drawings/d/12345/export/png" width="80%" alt="drawing">

</p>
<p>
Acesta este doar un exemplu pentru înțelegerea mecanismului, în realitate am fi obtinut un alt output.
</p>
<p>
Un exemplu cu setările inițiale 1|1|1 și fără mufe pe rotoarele folosite în program:
</p>
<p>

<img src="https://docs.google.com/drawings/d/12345/export/png" width="80%" alt="drawing">

</p>
<p>
Procesul din imaginea de mai sus este: 
</p>
<p>
Input: A;
</p>
<p>
A->P;  	P->H;  H->O; 
</p>
<p>
Intram in reflector cu O care devine X si ne intoarcem;
</p>
<p>
X->E;  E->D;  D->Y;
</p>
<p>
Output: Y;
</p>
<h1>Traducerea in cod</h1>


<h2>Variabile</h2>


<p>

<img src="images/image2.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
<strong>Acestea sunt variabilele care leaga elementele de UI de program.</strong>
</p>
<p>
Scurta descriere pentru tipurile folosite:
</p>
<p>
[SerializeField] = pastreaza variabila private dar ne da acces la ea din unity editor
</p>
<p>
GameObject = Tipul general de element prezent in scena din editorul Unity
</p>
<p>
Text = tipul de element folosit pentru UI Text.
</p>
<p>
Vectorul lights contine luminile care se “aprind” pentru output. “Aprinderea” si “stingerea” este de fapt activarea si dezactivarea obiectului.
</p>
<p>
Input, output sunt casutele de text unde scriem input si respectiv output. 
</p>
<p>
InputText1, InputText2, InputText3 sunt casutele de input pentru rotația rotoarelor.
</p>
<p>

<hr>
</p>
<p>

<img src="images/image3.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
<strong>Acestea sunt variabilele pentru rotoare.</strong>
</p>
<p>
r1, r2, r3, r4 sunt stringuri care contin setarile pentru rotoare in varianta lor de tip text. Am folosit aceasta varianta pentru a usura testarea si schimbarea din editor a setarilor, aceasta se poate face simplu cu copy-paste de pe <a href="https://en.wikipedia.org/wiki/Enigma_rotor_details#Rotor_wiring_tables">wiki</a>. Trebuie precizat ca r4 este reflectorul.
</p>
<p>
rotor1, rotor2, rotor3, rotor4 sunt vectori care contin valorile int ale setarilor, transformate din r1...r4 folosind o functie care va fi prezentata mai tarziu.
</p>
<p>
r1Rotation, r2Rotation, r3Rotation sunt variabile care stocheaza rotatia rotoarelor.
</p>
<p>

<hr>
</p>
<p>

<img src="images/image4.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
<strong>Acestea sunt variabilele pentru mufe</strong>
</p>
<p>
plugsOn verifica daca exista un meniu deschis care foloseste ca input litere, si este acompaniat de changePlugsOn(), o functie apelata de butoanele care deschid/inchid meniurile ce folosesc un astfel de input.
</p>
<p>
plugs este o matrice ce stocheaza 1 daca [i,j] are o conexiune, unde i si j sunt variantele numerice ale literelor; sau 0 daca nu exista o astfel de conexiune.
</p>
<p>

<hr>
</p>
<p>

<img src="images/image5.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
<strong>Acestea sunt variabilele de output</strong> 
</p>
<p>
Nu putem sa le stocam local pentru ca se vor reintializa in fiecare frame.
</p>
<p>
letterOutput este varianta numerica 
</p>
<p>
letterOutputS este varianta de tip string.
</p>
<p>

<hr>
</p>
<h2>Initializarea datelor </h2>


<p>

<img src="images/image6.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Explicatie:
</p>
<p>
inputText1.GetComponent&lt;TMP_InputField>().text  accesează din obiectul (GameObject) inputText1 componenta (.GetComponent) de tipul (&lt;TMP_InputField>()) pentru a schimba proprietatea text (.text).
</p>
<p>
In initializare folosim functia InitializeRotors() care transforma stringul de setari in vector de numere.
</p>
<p>


<p id="gdcalert13" ><span style="color: red; font-weight: bold">>>>>>  gd2md-html alert: inline image link here (to images/image7.png). Store image on your image server and adjust path/filename/extension if necessary. </span><br>(<a href="#">Back to top</a>)(<a href="#gdcalert14">Next alert</a>)<br><span style="color: red; font-weight: bold">>>>>> </span></p>


<img src="images/image7.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
(pentru letterToNumber() vezi 

<a href="#heading=h.hp2gssjceiq5">functii ajutatoare</a>)
</p>
<p>
Aceasta functie doar parcurge stringurile r1, r2, r3, r4 si vectorii pentru rotoare si pune in vectori varianta numerica a char ului respectiv.
</p>
<p>
 
</p>
<h2>Algoritmul de criptare</h2>


<p>
Algoritmul o sa fie prezentat pe pasi si apoi ca intreg.
</p>
<p>
<strong>Pasul 1 Verificarea inputului</strong>
</p>
<p>
Pentru a cripta o litera meniurile ce folosesc input alfabetic trebuie sa fie inchis (!plugsOn).
</p>
<p>
Inainte de a incepe verificarea inputului tratam cazul special “ “ (space) pentru a permite utilizatorului sa puna spatiu in  text.
</p>
<p>
Pentru a verifica daca utilizatorul a apasat o litera contruim un vector de litere si verificam la fiecare frame daca una din ele a fost apasata
</p>
<p>

<img src="images/image8.png" width="" alt="alt_text" title="image_tooltip">
Daca putem sa criptam si utilizatorul introduce spatiu doar scriem spatiu in input si output.
</p>
<p>

<img src="images/image9.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Aceasta bucata de cod verifica daca a mai fost ceva introdus inainte sau nu.
</p>
<p>

<img src="images/image10.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
letterS este varianta de tip string a literei pe care o verificam acum.
</p>
<p>
letterN este varianta numerica a literei pe care o verificam acum.
</p>
<p>
Construim vectorul de litere letters de tip char[], nu de string pentru ca avem nevoie sa transformam in int pentru calcule, iar transformarea din string in int este mai greu de realizat decat cea din char in int.
</p>
<p>

<img src="images/image11.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Verificam daca litera curenta a fost apasata. Input.GetKeyDown se activeaza o singura data cand litera a fost apasata complet.
</p>
<p>
<strong>Pasul 2 Verificam daca exista o mufa conectata</strong>
</p>
<p>

<img src="images/image12.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>


<img src="images/image13.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Schimbam letterN cu CheckPlugs(letterN), astfel daca exista o mufa conectata letterN devine litera cu care este conectata, iar daca nu, ramana aceeași valoare.
</p>
<p>
<strong>Pasul 3 Folosim rotoarele</strong> 
</p>
<p>


<img src="images/image14.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Salvam in letterOutput valoarea obtinuta dupa folosirea rotoarelor cu valoarea initiala letterN si cu modificarea rotatiei rotoarelor din interfata (true).
</p>
<p>


<img src="images/image15.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Sa analizam pe rand elementele din aceasta functie.
</p>
<p>


<img src="images/image16.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Letter devine pe rand valoarea din rotor aflata la litera curenta. Aceasta bucata de cod realizarea schimbarea prezentata 

<a href="#heading=h.of0nkl96sc5n">aici</a> cu liniile negre.
</p>
<p>

<img src="images/image17.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Aceasta bucata de cod face schimbaarile prezentate la functionarea rotoarelor cu linia verde, adica intoarcerea dupa ce valoarea a fost cea din reflector. Pentru fiecare litera intr-un rotor verificam ce index are litera curenta. Acel index este litera din ordinea alfabetica care corespunde cu litera curenta.
</p>
<p>

<img src="images/image18.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
La final doar rotim rotoarele si returnam litera dupa ce a fost schimbata. Acest return duce valoarea in letterOutputN.
</p>
<p>
rotateRotors(update), in cazul nostru update este true, adica dorim sa schimbam partea de UI care arata rotatia.
</p>
<p>

<img src="images/image19.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
In aceasta functie rotim primul rotor, si daca acesta ajunge inapoi la 1, il rotim si pe al doilea cu o iteratie, daca acea iteratie ajunge inapoi la 1 pentru al doilea rotor atunci rotim si al treilea rotor cu o iteratie.
</p>
<p>
La final schimbam partea de UI daca aceasta trebuie schimbata
</p>
<p>
<strong>Pasul 4 Verificam iar mufele si aprindem beculetul </strong>
</p>
<p>

<img src="images/image20.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Verificam iar daca exista o mufa conectata, dar de data asta la output, si, dacă este cazul schimbat outputul cu litera conectata.
</p>
<p>
Aprindem beculetul de la litera obtinuta.
</p>
<p>

<img src="images/image21.png" width="" alt="alt_text" title="image_tooltip">
 
</p>
<p>
<strong>Pasul 5 Actualizam elementele de UI</strong>
</p>
<p>

<img src="images/image22.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Daca utilizaatorul ridica tasta apasata anterior convertim rezultatul numeric in string si il afisam in casuta de output, cu inputul adaugat in casuta de input. De asemenea aici oprim beculetul aprins anterior.
</p>
<p>
<strong>Codul complet pentru criptarea unei litere</strong>
</p>
<h2>Setari</h2>


<p>
<strong>Rotoare</strong>
</p>
<p>

<img src="images/image23.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Chemam rotateRotors(false) (fara sa actualizam si UI-ul) pana cand rotatia este egala cu valoarea introdusa.
</p>
<p>
<strong>Mufe</strong>
</p>
<p>
Setarile de la mufe se afla pe fiecare mufa in parte si actualizeaza din exterior variabila plugs[,].
</p>
<p>

<img src="images/image24.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Fiecare capat de mufa are un capat conectat (connectedTo) si o referinta la enigma care stocheaza plugs[,].
</p>
<p>

<img src="images/image25.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Initializam textul din acest capat de mufa cu “ “.
</p>
<p>
De fiecare data cand utilizatorul incearca sa schimbe valoarea din casuta de input pentru o litera se cheama urmatoarea functie:
</p>
<p>

<img src="images/image26.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Sa analizam pe parti.
</p>
<p>


<img src="images/image27.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Verifica daca litera introdusa are pe campul partener ceva introdus. Daca are putem sa verificam daacaa pastram inputul sau nu, daca nu are atunci nu facem nimic.
</p>
<p>


<img src="images/image28.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Verificam daca a fost introdusa o singura litera sau mai multe. Daca este una singura putem sa continuam.
</p>
<p>


<img src="images/image29.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
J si k sunt valorile numerice ale literelor introduse.
</p>
<p>

<img src="images/image30.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Verificam daca putem sa pastram acest input.
</p>
<p>


<img src="images/image31.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Verificam daca perechea a mai fost introdusa, daca a fost introdusa o litera de doua ori si daca ambele au ca format o singura litera. Daca inputul respecta toate conditiile necesare atunci check o sa fie true, daca incalca oricare dintre ele, atunci o sa fie false.
</p>
<p>


<img src="images/image32.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Daca este true atunci schimbam valoarea din plugs[j,k]=plugs[k,j] in 1. Matriceea este simetrica cu diagonala secundara linie de simetrie. Diagonala principala o sa fie mereu 0.
</p>
<p>
Daca nu sunt indeplinite conditiile atunci doar scriem “ “ in locurile in care inputul nu a fost bun.
</p>
<p>
Pentru mufe avem si optiunea de a reseta valorile:
</p>
<p>


<img src="images/image33.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Aici reinitializam plugs[,] si scriem peste tot “ “.
</p>
<h2>Functii ajutatoare</h2>


<p>


<img src="images/image34.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Schimbare din int in string.
</p>
<p>


<img src="images/image35.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Schimbare din char in int. Aici folosim -1 pentru a incepe cu a=0 nu a=1.
</p>
<h1>Note</h1>


<p>

<hr>
</p>
<p>
Daca la rotoare se introduce o alta valoare care nu este cuprinsa intre 1 si 26 programul o sa intre într-un loop infinit pentru ca rnRotation cu n={1,2,3} are valori doar in intervalul [1,26].
</p>
<p>


<img src="images/image36.png" width="" alt="alt_text" title="image_tooltip">

</p>
<p>
Aceasta bucata de cod exemplifica situatia unui loop infinit.
</p>
<p>

<hr>
</p>
<p>
La meniul de mufe nu exista o modalitata usoara de a schimba conexiunile. O modalitate mai buna ar putea fi implementata.
</p>
<p>
Daca utilizatorul ar incerca sa schimbe o conexiune deja scrisa atunci conexiunea deja scrisa ar ramane activa si ar fi adaugata si conexiunea noua depasind astfel numarul de 10 conexiuni si blocand litere in conexiuni pe care nu poate sa le mai vada.
</p>
<p>

<hr>
</p>
<p>
Ar putea fi adaugata o modalitate de resetare a casutelor de input si output.
</p>
<p>

<hr>
</p>
<p>
 
</p>
<p>
Daca sunt apasate mai multe taste simultan atunci outputul o sa fie gresit iar luminile o sa se blocheze pe pozitia activa. Aceest lucru se datoreaza faptului ca testele sunt facute in functia Update() care se updateaza la fiecare frame, astfel daca doua taste sunt apasate valoarea de output de la una dintre ele o sa fie pierduta. 
</p>
<h1>Bibliografie</h1>


<p>
Programul folosit pentru realizarea aplicatiei: <a href="https://unity.com/">unity</a>
</p>
<p>
Modelul 3d folosit: <a href="https://sketchfab.com/3d-models/enigma-machine-1934-c8ee76c383654e3095ea4cc9e7990274">Enigma</a>
</p>
<p>
Poza folosita pentru mufe: <a href="https://calculate.org.au/2015/02/03/crack-enigma-code/">https://calculate.org.au/2015/02/03/crack-enigma-code/</a> 
</p>
<p>
Poza folosita pentru rotoare: <a href="https://en.wikipedia.org/wiki/Enigma_rotor_details">https://en.wikipedia.org/wiki/Enigma_rotor_details</a>
</p>
<p>
Linkuri folosite pentru intelegerea mecanismului si traducerea sa in aplicatie:
</p>
<p>
<a href="https://en.wikipedia.org/wiki/Enigma_rotor_details">https://en.wikipedia.org/wiki/Enigma_rotor_details</a>
</p>
<p>
<a href="https://en.wikipedia.org/wiki/Enigma_machine">https://en.wikipedia.org/wiki/Enigma_machine</a>
</p>
<p>
<a href="https://www.youtube.com/watch?v=G2_Q9FoD-oQ&ab_channel=Numberphile">https://www.youtube.com/watch?v=G2_Q9FoD-oQ&ab_channel=Numberphile</a>
</p>
<p>
<a href="https://www.youtube.com/watch?v=ASfAPOiq_eQ&t=323s&ab_channel=WorldScienceFestival">https://www.youtube.com/watch?v=ASfAPOiq_eQ&t=323s&ab_channel=WorldScienceFestival</a>
</p>
<p>
<a href="https://youtu.be/2D2bJWHvqJo">https://youtu.be/2D2bJWHvqJo</a>
</p>
<p>
Materiale recomandate pentru folosirea programului Unity:
</p>
<p>
<a href="https://docs.unity3d.com/Manual/index.html">https://docs.unity3d.com/Manual/index.html</a>
</p>
<p>
<a href="https://www.youtube.com/user/Brackeys">https://www.youtube.com/user/Brackeys</a>
</p>
<p>
<a href="https://www.youtube.com/watch?v=GhQdlIFylQ8&ab_channel=freeCodeCamp.org">https://www.youtube.com/watch?v=GhQdlIFylQ8&ab_channel=freeCodeCamp.org</a>
</p>
