using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaEsLinqTananyag
{
    /*
        TANANYAG: Lambda-kifejezések és LINQ C# nyelven
        Célcsoport: technikum, 13. évfolyam
        Cél: gyakorlati megértés + olyan szintű magyarázat, hogy a tanuló szóban is el tudja mondani

        FONTOS:
        - Ez a fájl egyszerre jegyzet és futtatható konzolos program.
        - A kommentek magyarázzák az elméletet.
        - A konzolos kiírások csak segédeszközök: nem a szépség a lényeg, hanem a megértés.

        MIT ÉRDEMES BELŐLE VIZSGÁRA TUDNI?
        1. Mi a lambda-kifejezés?
        2. Hogyan kapcsolódik a metódusokhoz?
        3. Mire használjuk a lambdákat LINQ-ban?
        4. Melyek a legfontosabb LINQ-metódusok, és mit csinálnak?
        5. Mik a tipikus hibák vagy félreértések?

        EGY MONDATOS MEGFOGALMAZÁS:
        "A lambda egy röviden leírt névtelen függvény, amit gyakran átadunk más metódusoknak,
        például LINQ-függvényeknek szűréshez, átalakításhoz, rendezéshez."

        TÖMÖR SZÓBELI VÁLASZ A LINQ-RA:
        "A LINQ olyan C#-eszközkészlet, amellyel gyűjteményeken és más adatforrásokon egységes,
        jól olvasható módon tudunk lekérdezéseket végezni, például szűrni, rendezni, csoportosítani,
        kiválasztani vagy összesíteni adatokat."
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var students = CreateStudents();
            var numbers = CreateNumbers();

            PrintTitle("C# lambda-kifejezések és LINQ - tananyagdemó");

            Intro();
            LambdaBasics(students);
            LambdaSyntaxMiniGuide();
            LinqBasics(students, numbers);
            LinqAdvanced(students, numbers);
            CommonMistakes(students);
            OralExamSummary();

            PrintTitle("A program véget ért");
        }

        // --------------------------------------------------------------------
        // 1. BEVEZETÉS
        // --------------------------------------------------------------------
        static void Intro()
        {
            PrintSection("1. Bevezetés");

            Console.WriteLine("Ebben a fájlban a lambda-kifejezések és a LINQ gyakorlati használatát nézzük meg.");
            Console.WriteLine("A fókusz nem az elméleti mélység, hanem az, hogy érthető és használható legyen.");
            Console.WriteLine();

            /*
                FONTOS PEDAGÓGIAI KAPASZKODÓ:
                Aki érti a metódusokat, az a lambdát így értheti meg a legkönnyebben:

                Normál metódus:
                    static int Square(int x)
                    {
                        return x * x;
                    }

                Ugyanez lambdaként:
                    x => x * x

                Vagyis:
                - van paraméter
                - van visszatérési érték
                - csak rövidebben írjuk le
                - sokszor ott helyben adjuk át, ahol szükség van rá

                A lambda tehát NEM varázslat.
                Olyan, mint egy "kis, névtelen, helyben megadott metódus".
            */

            Console.WriteLine("Kulcsgondolat: a lambda olyan, mint egy rövid, névtelen, helyben megadott metódus.");
            Console.WriteLine("Kulcsgondolat: a LINQ nagyon gyakran lambdákat vár paraméterként.");
            Console.WriteLine();
        }

        // --------------------------------------------------------------------
        // 2. LAMBDA-ALAPOK
        // --------------------------------------------------------------------
        static void LambdaBasics(List<Student> students)
        {
            PrintSection("2. Lambda-alapok");

            /*
                INDULJUNK A METÓDUSBÓL.

                A tanuló ezt már ismeri:
                - van egy metódusunk
                - meghívjuk
                - kap paramétert
                - visszaad valamit

                Később rájövünk, hogy néha nem az a lényeg, hogy a metódusnak neve legyen,
                hanem az, hogy egy logikát át tudjunk adni valaminek.

                Példa:
                - "szűrd ki a nagykorú tanulókat"
                - "rendezd átlag szerint"
                - "alakítsd át a tanulókat nevekké"

                Ezeknél a LINQ-metódusoknak átadunk egy szabályt.
                Ezt a szabályt legtöbbször lambdával adjuk meg.
            */

            Console.WriteLine("Normál metódus és lambda összehasonlítása:");
            Console.WriteLine();

            var adultsByNamedMethod = students.Where(IsAdult).ToList();
            var adultsByLambda = students.Where(s => s.Age >= 18).ToList();

            Console.WriteLine($"Nagykorúak száma névvel rendelkező metódussal: {adultsByNamedMethod.Count}");
            Console.WriteLine($"Nagykorúak száma lambdával: {adultsByLambda.Count}");
            Console.WriteLine();

            /*
                FONTOS:
                A Where egy olyan függvényt vár, amely minden elemről eldönti, hogy maradjon-e.
                Vagyis valami olyat vár, ami:
                    Student -> bool

                Ezt többféleképpen is megadhatjuk:

                1. külön metódussal:
                    static bool IsAdult(Student s) { return s.Age >= 18; }

                2. Func típussal:
                    Func<Student, bool> rule = s => s.Age >= 18;

                3. közvetlenül helyben:
                    students.Where(s => s.Age >= 18)

                Vizsgán jó mondat:
                "A lambda ugyanazt a logikát tudja leírni, mint egy rövid metódus,
                csak név nélkül és általában ott, ahol felhasználjuk."
            */

            Func<Student, bool> adultRule = s => s.Age >= 18;
            var adultsByFuncVariable = students.Where(adultRule).ToList();

            Console.WriteLine($"Nagykorúak száma Func változóval: {adultsByFuncVariable.Count}");
            Console.WriteLine();

            /*
                RÖVIDEN A FUNC-RÓL

                Func<...> egy beépített delegate-típus.
                Egyszerűen fogalmazva:
                olyan változó, amely függvénytárolásra használható.

                Példák:
                    Func<int, int> doubleIt = x => x * 2;
                    Func<int, int, int> add = (a, b) => a + b;
                    Func<Student, string> getName = s => s.Name;

                Az utolsó típusparaméter a visszatérési érték típusa.
            */

            Func<int, int> doubleIt = x => x * 2;
            Func<int, int, int> add = (a, b) => a + b;

            Console.WriteLine($"doubleIt(5) = {doubleIt(5)}");
            Console.WriteLine($"add(3, 4) = {add(3, 4)}");
            Console.WriteLine();

            /*
                ACTION RÖVIDEN:
                Az Action is függvényt képvisel, de nincs visszatérési értéke.
                Ez vizsgán nem a legfontosabb, de jó tudni.

                    Action<string> say = name => Console.WriteLine(name);

                Ha a kérdés kifejezetten a lambdák és a metódusok kapcsolata,
                akkor a Func általában elég.
            */

            Action<string> greet = name => Console.WriteLine($"Szia, {name}!");
            greet("vizsgázó");

            Console.WriteLine();

            /*
                BLOKKLAMBDA:
                Ha egy sor kevés, kapcsos zárójelet is használhatunk.

                    x => x * x

                helyett:

                    x =>
                    {
                        int result = x * x;
                        return result;
                    }

                Ez hasonlít legjobban a "sima metódusra", ezért sok tanulónak ezt a legkönnyebb megérteni.
            */

            Func<int, int> square = x =>
            {
                int result = x * x;
                return result;
            };

            Console.WriteLine($"square(6) = {square(6)}");
            Console.WriteLine();
        }

        static void LambdaSyntaxMiniGuide()
        {
            PrintSection("3. Lambda-szintaxis mini útmutató");

            /*
                A lambda általános alakja:

                    paraméter => kifejezés
                    vagy
                    paraméterek => { több utasítás }

                Példák:

                    x => x * 2
                    (a, b) => a + b
                    s => s.Name
                    s => s.Age >= 18

                Ha csak egy paraméter van, a zárójel elhagyható:
                    x => x * 2

                Ha több paraméter van, kell zárójel:
                    (a, b) => a + b

                Ha a jobb oldalon csak egy kifejezés van, annak az értéke lesz a visszatérési érték.
                Ha blokk van, akkor általában return kell.
            */

            Console.WriteLine("Lambdák tipikus formái:");
            Console.WriteLine("x => x * 2");
            Console.WriteLine("(a, b) => a + b");
            Console.WriteLine("s => s.Name");
            Console.WriteLine("s => s.Age >= 18");
            Console.WriteLine();

            /*
                SOK TANULÓ EZT KEVERI:

                Ez NEM lambda:
                    public int Double(int x) { return x * 2; }

                Ez metódus.

                Ez lambda:
                    x => x * 2

                Vagyis a lambda nem osztályszintű tagként van megírva névvel,
                hanem általában egy változóba kerül vagy paraméterként adjuk át.
            */

            Console.WriteLine("Fontos: a lambda nem ugyanaz, mint a névvel rendelkező metódus, csak hasonló logikát ír le.");
            Console.WriteLine();
        }

        // --------------------------------------------------------------------
        // 3. LINQ-ALAPOK
        // --------------------------------------------------------------------
        static void LinqBasics(List<Student> students, List<int> numbers)
        {
            PrintSection("4. A legfontosabb LINQ-metódusok");

            /*
                A LINQ a Language Integrated Query rövidítése.
                A lényege:
                - egységes módon tudunk adatokat lekérdezni
                - főleg gyűjteményeken használjuk
                - a módszeres, olvasható kódot támogatja

                Az itt bemutatott metódusok a legfontosabbak:
                - Where
                - Select
                - OrderBy / ThenBy
                - First / FirstOrDefault
                - Single / SingleOrDefault
                - Any / All
                - Count
                - Contains
                - Distinct
                - Skip / Take
                - Sum / Average / Min / Max
                - GroupBy
                - Join
                - MaxBy (ha a környezet támogatja)
            */

            // ---------------------------
            // WHERE
            // ---------------------------
            /*
                Where = szűrés

                Csak azokat az elemeket hagyja meg, amelyekre a feltétel igaz.
                A visszatérési érték NEM egyetlen elem, hanem egy új sorozat.
            */
            var adults = students.Where(s => s.Age >= 18).ToList();
            Console.WriteLine("Where - nagykorú tanulók:");
            PrintStudents(adults);

            // ---------------------------
            // SELECT
            // ---------------------------
            /*
                Select = átalakítás

                Nem szűr, hanem minden elemből készít valami újat.
                Például Student objektumból csak a név.
            */
            var names = students.Select(s => s.Name).ToList();
            Console.WriteLine("Select - csak nevek:");
            PrintItems(names);

            var shortInfo = students
                .Select(s => $"{s.Name} - átlag: {s.AverageGrade:F1}")
                .ToList();

            Console.WriteLine("Select - átalakított szövegek:");
            PrintItems(shortInfo);

            // ---------------------------
            // ORDERBY, ORDERBYDESCENDING, THENBY
            // ---------------------------
            /*
                OrderBy = növekvő rendezés
                OrderByDescending = csökkenő rendezés
                ThenBy = másodlagos rendezés
            */
            var orderedByAverage = students
                .OrderByDescending(s => s.AverageGrade)
                .ThenBy(s => s.Name)
                .ToList();

            Console.WriteLine("OrderByDescending + ThenBy - átlag szerint csökkenően, név szerint másodlagosan:");
            PrintStudents(orderedByAverage);

            // ---------------------------
            // FIRST, FIRSTORDEFAULT
            // ---------------------------
            /*
                First = az első elemet adja vissza
                Ha nincs ilyen elem, hibát dob.

                FirstOrDefault = az első elemet adja vissza
                Ha nincs ilyen elem, alapértéket ad vissza:
                - referencia típusnál null
                - int esetén 0
                - bool esetén false
                stb.
            */
            var firstAdult = students.First(s => s.Age >= 18);
            var firstExcellent = students.FirstOrDefault(s => s.AverageGrade > 5.0);

            Console.WriteLine($"First - első nagykorú: {firstAdult.Name}");

            if (firstExcellent == null)
            {
                Console.WriteLine("FirstOrDefault - nincs 5.0-nál jobb átlagú tanuló, ezért null lett az eredmény.");
            }

            Console.WriteLine();

            // ---------------------------
            // SINGLE, SINGLEORDEFAULT
            // ---------------------------
            /*
                Single = pontosan egy elemet vár
                - ha nincs ilyen, hibát dob
                - ha több ilyen van, akkor is hibát dob

                Akkor jó, ha biztosan egyetlen találatnak kell lennie.
                Például egyedi azonosító alapján keresésnél.
            */
            var studentWithId3 = students.Single(s => s.Id == 3);
            var missingStudent = students.SingleOrDefault(s => s.Id == 999);

            Console.WriteLine($"Single - Id = 3 -> {studentWithId3.Name}");
            Console.WriteLine($"SingleOrDefault - Id = 999 -> {(missingStudent == null ? "null" : missingStudent.Name)}");
            Console.WriteLine();

            // ---------------------------
            // ANY, ALL
            // ---------------------------
            /*
                Any = van-e legalább egy ilyen elem?
                All = minden elem megfelel-e a feltételnek?
            */
            bool hasMinor = students.Any(s => s.Age < 18);
            bool everyonePassed = students.All(s => s.AverageGrade >= 2.0);

            Console.WriteLine($"Any - van kiskorú? {hasMinor}");
            Console.WriteLine($"All - mindenki átment? {everyonePassed}");
            Console.WriteLine();

            // ---------------------------
            // COUNT
            // ---------------------------
            /*
                Count = elemszám vagy feltételnek megfelelő elemek száma
            */
            int adultCount = students.Count(s => s.Age >= 18);
            Console.WriteLine($"Count - nagykorúak száma: {adultCount}");
            Console.WriteLine();

            // ---------------------------
            // CONTAINS
            // ---------------------------
            /*
                Contains = benne van-e az adott érték a sorozatban?

                Egyszerű típusoknál (pl. int, string) kényelmes.
                Objektumoknál figyelni kell, mert ott az egyenlőség kérdése bonyolultabb lehet.
            */
            bool containsSeven = numbers.Contains(7);
            bool containsName = students.Select(s => s.Name).Contains("Anna");

            Console.WriteLine($"Contains - szerepel a 7 a számlistában? {containsSeven}");
            Console.WriteLine($"Contains - van Anna nevű tanuló? {containsName}");
            Console.WriteLine();

            // ---------------------------
            // DISTINCT
            // ---------------------------
            /*
                Distinct = ismétlődő elemek kiszűrése
            */
            var classNames = students.Select(s => s.ClassName).Distinct().OrderBy(c => c).ToList();
            Console.WriteLine("Distinct - különböző osztályok:");
            PrintItems(classNames);

            // ---------------------------
            // SKIP, TAKE
            // ---------------------------
            /*
                Skip = elemek kihagyása az elejéről
                Take = bizonyos számú elem kivétele az elejéről

                Gyakori használat: lapozás, első N elem, toplista-részlet
            */
            var firstThreeStudents = students.Take(3).Select(s => s.Name).ToList();
            var afterSkippingTwo = students.Skip(2).Take(3).Select(s => s.Name).ToList();

            Console.WriteLine("Take - első 3 tanuló:");
            PrintItems(firstThreeStudents);

            Console.WriteLine("Skip(2).Take(3) - 2 kihagyása után a következő 3 tanuló:");
            PrintItems(afterSkippingTwo);

            // ---------------------------
            // SUM, AVERAGE, MIN, MAX
            // ---------------------------
            /*
                Összesítő műveletek
            */
            int numberSum = numbers.Sum();
            double averageGrade = students.Average(s => s.AverageGrade);
            int minNumber = numbers.Min();
            int maxNumber = numbers.Max();

            Console.WriteLine($"Sum - számok összege: {numberSum}");
            Console.WriteLine($"Average - tanulók átlagainak átlaga: {averageGrade:F2}");
            Console.WriteLine($"Min - legkisebb szám: {minNumber}");
            Console.WriteLine($"Max - legnagyobb szám: {maxNumber}");
            Console.WriteLine();

            /*
                VIZSGÁN JÓ RÖVID MONDATOK:

                - Where: szűrés
                - Select: átalakítás
                - OrderBy: rendezés
                - FirstOrDefault: első elem vagy alapérték
                - Any: létezik-e ilyen elem
                - All: minden elem megfelel-e
                - Count: darabszám
                - Distinct: ismétlődések eltávolítása
                - Skip/Take: részhalmaz kiválasztása
            */
        }

        // --------------------------------------------------------------------
        // 4. HALADÓBB LINQ-PÉLDÁK
        // --------------------------------------------------------------------
        static void LinqAdvanced(List<Student> students, List<int> numbers)
        {
            PrintSection("5. Haladóbb, de nagyon hasznos LINQ-példák");

            // ---------------------------
            // GROUPBY
            // ---------------------------
            /*
                GroupBy = csoportosítás valamilyen kulcs szerint

                Például osztályonként csoportosítjuk a tanulókat.
            */
            var groupedByClass = students
                .GroupBy(s => s.ClassName)
                .OrderBy(g => g.Key);

            Console.WriteLine("GroupBy - tanulók osztályonként:");
            foreach (var group in groupedByClass)
            {
                Console.WriteLine($"Osztály: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  - {student.Name} ({student.AverageGrade:F1})");
                }
            }
            Console.WriteLine();

            // ---------------------------
            // JOIN
            // ---------------------------
            /*
                Join = két adatforrás összekapcsolása közös kulcs alapján

                Ez hasonlít az SQL JOIN-hoz.
            */
            var classes = CreateClasses();

            var joined = students.Join(
                classes,
                student => student.ClassName,
                schoolClass => schoolClass.Name,
                (student, schoolClass) => new
                {
                    StudentName = student.Name,
                    ClassName = schoolClass.Name,
                    Teacher = schoolClass.ClassTeacher
                });

            Console.WriteLine("Join - tanuló és osztályfőnök összekapcsolása:");
            foreach (var item in joined)
            {
                Console.WriteLine($"{item.StudentName} - {item.ClassName} - osztályfőnök: {item.Teacher}");
            }
            Console.WriteLine();

            // ---------------------------
            // SELECTMANY (opcionális, de hasznos)
            // ---------------------------
            /*
                SelectMany = beágyazott gyűjtemények "kilapítása"

                Nem a legelső LINQ-metódus, amit tanítani kell,
                de jó látni, hogy létezik.
            */
            var studentsWithTags = CreateStudentsWithTags();

            var allTags = studentsWithTags
                .SelectMany(s => s.Tags)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            Console.WriteLine("SelectMany - minden egyedi címke a tanulókból:");
            PrintItems(allTags);

            // ---------------------------
            // MAXBY (NET 6+)
            // ---------------------------
            /*
                MaxBy = azt az elemet adja vissza, amelynél egy adott kulcs maximális.

                Különbség:
                - Max(s => s.AverageGrade) csak a legnagyobb számot adja
                - MaxBy(s => s.AverageGrade) magát a tanulót adja

                FONTOS:
                A MaxBy a modernebb .NET-verziókban érhető el.
                Régebbi környezetben nincs.
            */
#if NET6_0_OR_GREATER
            var bestStudent = students.MaxBy(s => s.AverageGrade);
            Console.WriteLine($"MaxBy - legjobb átlagú tanuló: {bestStudent?.Name} ({bestStudent?.AverageGrade:F1})");
#else
            var bestStudentFallback = students
                .OrderByDescending(s => s.AverageGrade)
                .First();

            Console.WriteLine("MaxBy - ha a környezet nem támogatja, ugyanaz kiváltható így:");
            Console.WriteLine($"OrderByDescending(...).First() -> {bestStudentFallback.Name} ({bestStudentFallback.AverageGrade:F1})");
#endif
            Console.WriteLine();

            // ---------------------------
            // QUERY SYNTAX VS METHOD SYNTAX
            // ---------------------------
            /*
                A LINQ-nak két gyakori írásmódja van:

                1. Method syntax (ezt használjuk többet C#-ban):
                    students.Where(s => s.Age >= 18).Select(s => s.Name)

                2. Query syntax:
                    from s in students
                    where s.Age >= 18
                    select s.Name

                Vizsgára jó tudni, hogy mindkettő létezik.
                A gyakorlatban C#-ban a method syntax sokszor gyakoribb.
            */

            var adultNamesMethodSyntax = students
                .Where(s => s.Age >= 18)
                .Select(s => s.Name)
                .ToList();

            var adultNamesQuerySyntax =
                (from s in students
                 where s.Age >= 18
                 select s.Name)
                .ToList();

            Console.WriteLine("Method syntax eredménye:");
            PrintItems(adultNamesMethodSyntax);

            Console.WriteLine("Query syntax eredménye:");
            PrintItems(adultNamesQuerySyntax);

            // ---------------------------
            // KOMBINÁLT, VALÓSZERŰ LINQ-PÉLDA
            // ---------------------------
            /*
                Ilyesmi már kifejezetten életszerű:
                - szűrés
                - rendezés
                - átalakítás
                - lista materializálása
            */
            var scholarshipCandidates = students
                .Where(s => s.Age >= 18 && s.AverageGrade >= 4.5)
                .OrderByDescending(s => s.AverageGrade)
                .ThenBy(s => s.Name)
                .Select(s => $"{s.Name} - {s.ClassName} - {s.AverageGrade:F1}")
                .ToList();

            Console.WriteLine("Komplex példa - ösztöndíjra esélyes tanulók:");
            PrintItems(scholarshipCandidates);
        }

        // --------------------------------------------------------------------
        // 5. GYAKORI HIBÁK ÉS FÉLREÉRTÉSEK
        // --------------------------------------------------------------------
        static void CommonMistakes(List<Student> students)
        {
            PrintSection("6. Gyakori hibák és félreértések");

            // 1. Where nem módosítja az eredeti listát
            /*
                NAGYON GYAKORI HIBA:
                Sokan azt hiszik, hogy a Where "kitörli" a többi elemet az eredeti listából.
                Nem.
                A Where új sorozatot ad vissza.
            */
            var adults = students.Where(s => s.Age >= 18).ToList();

            Console.WriteLine($"Eredeti lista elemszáma: {students.Count}");
            Console.WriteLine($"Szűrt lista elemszáma: {adults.Count}");
            Console.WriteLine("A Where tehát nem írja át az eredeti listát.");
            Console.WriteLine();

            // 2. Where és Select keverése
            /*
                Where = eldönti, hogy maradjon-e az elem
                Select = átalakítja az elemet

                Rossz gondolat:
                - "A Select majd kiszűri a nagykorúakat"

                Nem.
                A Select nem szűrésre való.
            */
            var adultNames = students
                .Where(s => s.Age >= 18)
                .Select(s => s.Name)
                .ToList();

            Console.WriteLine("Where + Select együtt:");
            PrintItems(adultNames);

            // 3. First és FirstOrDefault különbsége
            /*
                First hibát dobhat, ha nincs találat.
                FirstOrDefault biztonságosabb lehet, de utána ellenőrizni kell az eredményt.
            */
            var maybeStudent = students.FirstOrDefault(s => s.Name == "NincsIlyenNév");

            if (maybeStudent == null)
            {
                Console.WriteLine("FirstOrDefault után null-ellenőrzés kellhet.");
            }
            Console.WriteLine();

            // 4. Any() sokszor jobb, mint Count() > 0
            /*
                Ha csak azt akarjuk tudni, hogy van-e legalább egy találat,
                akkor az Any() kifejezőbb, és általában jobb választás.

                Rosszabb stílus:
                    students.Where(...).Count() > 0

                Jobb:
                    students.Any(...)
            */
            bool hasExcellentStudent = students.Any(s => s.AverageGrade >= 4.8);
            Console.WriteLine($"Any - van legalább egy 4.8 vagy jobb átlagú tanuló? {hasExcellentStudent}");
            Console.WriteLine();

            // 5. OrderBy után újabb OrderBy
            /*
                FONTOS:
                Ha már rendeztünk, és utána újra OrderBy-t használunk,
                az újrarendezi az egészet, nem "másodlagos" rendezést ad hozzá.

                Másodlagos rendezéshez ThenBy kell.
            */
            var wrongOrdering = students
                .OrderBy(s => s.ClassName)
                .OrderByDescending(s => s.AverageGrade)
                .ToList();

            var correctOrdering = students
                .OrderBy(s => s.ClassName)
                .ThenByDescending(s => s.AverageGrade)
                .ToList();

            Console.WriteLine("Rossz rendezés (OrderBy után újabb OrderBy):");
            PrintStudents(wrongOrdering);

            Console.WriteLine("Jó rendezés (OrderBy után ThenByDescending):");
            PrintStudents(correctOrdering);

            // 6. Deferred execution - halasztott végrehajtás
            /*
                EZ MÁR KÖZÉPHALADÓ, DE NAGYON HASZNOS:

                Sok LINQ-lekérdezés nem azonnal fut le, hanem csak akkor,
                amikor ténylegesen bejárjuk vagy materializáljuk.

                Ezért az eredmény változhat, ha a forráslista időközben megváltozik.
            */
            var query = students.Where(s => s.Age >= 18);

            students.Add(new Student
            {
                Id = 99,
                Name = "Zsófi",
                Age = 19,
                AverageGrade = 4.9,
                ClassName = "13.C"
            });

            Console.WriteLine($"Deferred execution példa - a lekérdezés később fut le, ezért a darabszám már az új elemet is figyelembe veszi: {query.Count()}");
            Console.WriteLine();

            /*
                Ha "pillanatképet" akarunk, akkor gyakran ToList() vagy ToArray() kell.
            */
            var snapshot = students.Where(s => s.Age >= 18).ToList();
            students.Add(new Student
            {
                Id = 100,
                Name = "Péter",
                Age = 20,
                AverageGrade = 3.7,
                ClassName = "13.A"
            });

            Console.WriteLine($"A ToList() már pillanatképet készített, ezért a snapshot mérete nem változik: {snapshot.Count}");
            Console.WriteLine();

            // 7. Objektumok Contains használata
            /*
                Objektumoknál a Contains nem mindig úgy működik,
                ahogy a kezdők várják, mert az egyenlőség kérdése számít.

                Ezért sokszor biztosabb valamilyen kulcs alapján vizsgálni:
                    students.Any(s => s.Id == keresettId)
            */
            bool hasId3 = students.Any(s => s.Id == 3);
            Console.WriteLine($"Objektum keresése kulcs alapján - van Id=3? {hasId3}");
            Console.WriteLine();
        }

        // --------------------------------------------------------------------
        // 6. SZÓBELI VIZSGÁS ÖSSZEFOGLALÓ
        // --------------------------------------------------------------------
        static void OralExamSummary()
        {
            PrintSection("7. Rövid szóbeli vizsgás összefoglaló");

            /*
                Ezt a részt szinte szó szerint is meg lehet tanulni.

                LEHETSÉGES VÁLASZ:
                "A lambda-kifejezés egy rövid, névtelen függvény, amelyet gyakran akkor használunk,
                amikor valamilyen művelet logikáját át akarjuk adni egy másik metódusnak.
                Ha valaki érti a metódusokat, akkor a lambda úgy fogható fel, mint egy név nélküli,
                rövidített metódus. Gyakran használjuk LINQ-ban.

                A LINQ segítségével gyűjteményeken tudunk lekérdezéseket végezni.
                A legfontosabb LINQ-metódusok:
                Where - szűrés,
                Select - átalakítás,
                OrderBy - rendezés,
                FirstOrDefault - első elem vagy alapérték,
                Any - van-e ilyen elem,
                All - minden elem megfelel-e,
                Count - darabszám,
                Distinct - ismétlődések eltávolítása,
                GroupBy - csoportosítás,
                Join - összekapcsolás.

                Fontos különbség, hogy a Where szűr, a Select átalakít.
                A Where nem módosítja az eredeti listát, hanem új sorozatot ad vissza.
                A First hibát dobhat, ha nincs találat, a FirstOrDefault pedig ilyenkor alapértéket ad."
            */

            Console.WriteLine("Mintaválaszok:");
            Console.WriteLine();

            Console.WriteLine("1) Mi a lambda-kifejezés?");
            Console.WriteLine("   A lambda egy rövid, névtelen függvény, amit gyakran más metódusoknak adunk át paraméterként.");
            Console.WriteLine();

            Console.WriteLine("2) Hogyan értheti meg könnyen az, aki már ismeri a metódusokat?");
            Console.WriteLine("   Úgy, hogy a lambda lényegében egy név nélküli, röviden leírt metóduslogika.");
            Console.WriteLine();

            Console.WriteLine("3) Mi a LINQ?");
            Console.WriteLine("   A LINQ a C# olyan eszközkészlete, amellyel adatokat tudunk szűrni, rendezni, átalakítani és összesíteni.");
            Console.WriteLine();

            Console.WriteLine("4) Melyek a legfontosabb LINQ-függvények?");
            Console.WriteLine("   Where, Select, OrderBy, ThenBy, First, FirstOrDefault, Single, Any, All, Count, Contains, Distinct, Skip, Take, Sum, Average, Min, Max, GroupBy, Join.");
            Console.WriteLine();

            Console.WriteLine("5) Mi a különbség a Where és a Select között?");
            Console.WriteLine("   A Where szűr, a Select átalakít.");
            Console.WriteLine();

            Console.WriteLine("6) Mire kell figyelni FirstOrDefault esetén?");
            Console.WriteLine("   Arra, hogy ha nincs találat, akkor alapértéket kapunk, referencia típusnál általában null-t.");
            Console.WriteLine();

            Console.WriteLine("7) Mit csinál a MaxBy?");
            Console.WriteLine("   Azt az elemet adja vissza, amelynél egy megadott kulcs a legnagyobb.");
            Console.WriteLine();
        }

        // --------------------------------------------------------------------
        // MINTAADATOK
        // --------------------------------------------------------------------
        static List<Student> CreateStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Anna", Age = 18, AverageGrade = 4.7, ClassName = "13.A" },
                new Student { Id = 2, Name = "Bence", Age = 17, AverageGrade = 3.9, ClassName = "13.A" },
                new Student { Id = 3, Name = "Csilla", Age = 19, AverageGrade = 4.9, ClassName = "13.B" },
                new Student { Id = 4, Name = "Dávid", Age = 18, AverageGrade = 2.8, ClassName = "13.B" },
                new Student { Id = 5, Name = "Eszter", Age = 20, AverageGrade = 4.4, ClassName = "13.C" },
                new Student { Id = 6, Name = "Ferenc", Age = 17, AverageGrade = 3.1, ClassName = "13.C" },
                new Student { Id = 7, Name = "Gréta", Age = 19, AverageGrade = 4.6, ClassName = "13.A" },
                new Student { Id = 8, Name = "Hunor", Age = 18, AverageGrade = 3.5, ClassName = "13.B" }
            };
        }

        static List<int> CreateNumbers()
        {
            return new List<int> { 7, 3, 7, 10, 2, 8, 10, 1, 5 };
        }

        static List<SchoolClass> CreateClasses()
        {
            return new List<SchoolClass>
            {
                new SchoolClass { Name = "13.A", ClassTeacher = "Kovács tanárnő" },
                new SchoolClass { Name = "13.B", ClassTeacher = "Nagy tanár úr" },
                new SchoolClass { Name = "13.C", ClassTeacher = "Szabó tanárnő" }
            };
        }

        static List<StudentWithTags> CreateStudentsWithTags()
        {
            return new List<StudentWithTags>
            {
                new StudentWithTags { Name = "Anna", Tags = new List<string> { "C#", "SQL", "Git" } },
                new StudentWithTags { Name = "Bence", Tags = new List<string> { "HTML", "CSS", "Git" } },
                new StudentWithTags { Name = "Csilla", Tags = new List<string> { "C#", "LINQ", "SQL" } }
            };
        }

        // --------------------------------------------------------------------
        // SEGÉDMETÓDUSOK
        // --------------------------------------------------------------------
        static bool IsAdult(Student student)
        {
            return student.Age >= 18;
        }

        static void PrintTitle(string title)
        {
            Console.WriteLine(new string('=', 70));
            Console.WriteLine(title);
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
        }

        static void PrintSection(string title)
        {
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(title);
            Console.WriteLine(new string('-', 70));
        }

        static void PrintItems<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }

            Console.WriteLine();
        }

        static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"- {student.Name}, kor: {student.Age}, átlag: {student.AverageGrade:F1}, osztály: {student.ClassName}");
            }

            Console.WriteLine();
        }
    }

    // ------------------------------------------------------------------------
    // MODELOSZTÁLYOK
    // ------------------------------------------------------------------------
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public double AverageGrade { get; set; }
        public string ClassName { get; set; } = "";
    }

    internal class SchoolClass
    {
        public string Name { get; set; } = "";
        public string ClassTeacher { get; set; } = "";
    }

    internal class StudentWithTags
    {
        public string Name { get; set; } = "";
        public List<string> Tags { get; set; } = new List<string>();
    }
}
