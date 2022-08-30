
/*
 * Opgaver til 2. Semester IT-Arkitetur, C# intro, Lektiecafé
 * OPGAVE SÆT 1
 */


//Her i feltet under, tester du din kode. Bare slet "//" foran Console.WriteLine for at prøve din kode af i consolen.

//opgave 1 tests:
// Console.WriteLine("Burde blive 30: " + StorTal(30, 30));
// Console.WriteLine("Burde blive 498: " + StorTal(355, 498));

// opgave 2 tests:
// Console.WriteLine("Burde blive 2: " + nummer3(new int[] {1,2,2,3,4}));
// Console.WriteLine("Burde blive 0: " + nummer3(new int[] { 1, 2 }));

// opgave 3 tests:
// Console.WriteLine("Burde være true: " + vokal("ups"));
// Console.WriteLine("Burde være false: " + vokal("lol"));

// opgave 6 tests:
// Console.WriteLine("Burde være 2: " + FireA(new int[] { 2, 2, 2, 2, 2, -2, -2, -2, -2, 0 }));
// Console.WriteLine("Burde være 0: " + FireA(new int[] { 9, 3, 23, 1, 6, -6, -1, -23, -3, -9 }));

// opgave 7 tests:
// Console.WriteLine("Burde være -1: " + FireATo(new int[] { 9, 3, -23, 1, 6, -6, -1, 23, -3, -9 }));
// Console.WriteLine("Burde være 0: " + FireATo(new int[] { 9, 3, 23, 1, 6, -6, -1, -23, -3, -9 }));


// Opgave 1
// Lav en funktion/metode der tager to integers, a og b, som input parametre og returnere det største af de to tal.
// Hvis a = b, returner a
static int StorTal(int a, int b)
{
    //Skriv din kode her
    return 123;
}


// Opgave 2
// Lav en funktion/metode tager et array af integers som input parameter og returnere der 3. tal i arrayet.
// Hvis der ikke er 3 tal i arrayet skal funktionen/metoden returnere 0
static int nummer3(int[] arr)
{
    //skriv koden her
    return 123;
  
}


// Opgave 3
// Lav en funktion/metode der tager en string som input parameter og returnerer en boolean, true eller false.
// Den skal returnere true hvis string'en starter men en vokal, altså a,e,i,o,u eller y, false ved alt andet.
static bool vokal(string str)
{
    //Skriv din kode her
    return false;
}


// Opgave 4
// Nu skal vi lave et lille consol program der tager input fra brugeren. Altså med Console.ReadLine()
// Lav et consol program der tager et tal fra brugeren og fortæller om tallet er med i 3-tabellen.
// Det vil sige hvis du indtaster 6 skal den sige "dette tal er med i 3-tabellen" og hvis du skriver 10 skal den sige "tallet er ikke med, øv"

// Skriv koden helt øverst i filen, IKKE HER!




// Opgave 5
// Nu udvider vi opgave 4! Ud over 3 tabellen skal skal programmet også kunne fortælle om tallet er med i 2-tabellen.
// Det vil sige at hvis tallet er med i 2 tabellen og 3 tabellen, fx hvis du skriver 6, skal skal den udskrive "tallet er med i både 2 og 3 tabellen"
// Hvis tallet kun er med i én af tabellerne skal den også kunne fortælle dig hvilken den er med i.

// Igen, skriv koden øverst i filen på første linje før alle funktionerne begynder.




// Opgave 6
// Bussen 4A har 10 stops på sin rute til Viby, ved hvert stop stiger passagere på og af bussen.
// Du skal finde ud af hvor mange passagere der stadig er på bussen efter sidste stop(de er nok faldet i søvn på vej i skole).
// Du får et array med 10 tal i, hvert tal repræsenterer et stop og tallet viser hvor mange passagere bussen har tilføjer/mistet ved stoppet. Bussen starter helt tom.
// Det vil sige dette array [30,15,5,0,0,-20,10,-15,10,-25] burde returnere 10.
static int FireA(int[] stops)
{
    //skriv din kode her
    return 123;
}



// Opgave 7
// Nu skal vi udvide opgave 6 og tjekke for fejl. Ham der står for at tælle mængden af passagerer der stiger af og på, tæller nogen gange forkert.
// Kan du se hvad fejlen er i dette array? [10,20,-5,-5,-9,-7,-7,14,8,-8]
// På 7. stop stiger der 7 ud, men hvor mange er der så med bussen efter 7. stop? -3? Det er noget sluder.
// Udvid funktionen til at returnere -1 hvis der er fejl i optælling, lige meget hvor stor fejlen er skal den bare returnere -1.
// Hvis der ingen fejl er, skal den stadig kunne returnere antallet der har glemt at stige af efter sidste stop.


static int FireATo(int[] stops)
{
    //skriv din kode her
    return 123;
}

// Opgave 8
// Der er fredagsbar på EAA og du er bartender. En øl koster 15 kroner stykket, men hvis du køber 10 kan du få dem til 12 kroner stykket.
// Lav et consol program der tager input fra brugeren, dette input er antal øl brugeren gerne vil købe og den billigste pris skal så udskives.
// Det vil sige input = 12 skal udskrive 150 (120 + 15 + 15) og input = 9 skal udskrive 135 (15 * 9).

// Igen, Skriv din consol øverst i filen, ellers virker det nok ikke.

// Opgave 9
// Udvid opgave 8 så brugeren også har muligheden for at købe shots. Det vil sige at der skal være 2 inputs (Console.ReadLine())
// Det første input er øl og andet input er shots. 10 shots koster 100 og et enkelt shot koster 12. Den samlede pris skal udskrives.

// Skriv koden øverst



// Opgave 10
// Hvis du ikke allerede har en github, så gå ind og opret dig. 
// Derefter, gå ind på Codewars.com og log ind via GitHub.
// Siden kan godt være lidt forvirrende, men det er faktisk ikke så svært, den er bare fyldt med lækre opgaver i både c# javascript og SQL.
// Find en opgave i sværhedsgraden 8Kyu og løs den!
// Den side er den eneste grund til at jeg acer mine kode-eksamner, så hvis du også vil have et par gode karaktere kan jeg varmt anbefale den. 
// Spørg hvis du har nogen spørgsmål til siden eller de andre opgaver.
// Ses næste uge  :)