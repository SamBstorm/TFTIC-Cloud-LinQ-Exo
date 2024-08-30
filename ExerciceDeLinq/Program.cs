using LINQDataContext;

namespace ExerciceDeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext();

            #region Faites vos exos ici
            /*2.1
            var QueryResult = dc.Students.Select(s => new
            {
                Nom = s.Last_Name,
                DateNaissance = s.BirthDate,
                s.Login,
                ResultatScolaire = s.Year_Result
            });

            foreach (var result in QueryResult) {
                Console.WriteLine($"{result.Nom}, {result.DateNaissance}, {result.Login}, {result.ResultatScolaire}");
            }
            */

            /*2.2
            var QueryResult = dc.Students.Select((s) => new { Name = $"{s.First_Name} {s.Last_Name}", s.BirthDate, s.Student_ID});

            foreach (var item in QueryResult)
            {
                Console.WriteLine($"{item.Name} , {item.Student_ID}, {item.BirthDate}");
            }*/

            /*2.3
            IEnumerable<string> queryResult = dc.Students.Select((s) => $"{s.Last_Name}|{s.First_Name}|{s.BirthDate}|{s.Login}|{s.Year_Result}|{s.Section_ID}|{s.Course_ID}|{s.Student_ID}");

            foreach (string item in queryResult)
            {
                Console.WriteLine(item);
            }
            */

            /*3.1
            var queryResult = dc.Students
                                    .Where((s) => s.BirthDate.Year < 1955)
                                    .Select((s) => new { 
                                        s.Last_Name, 
                                        s.Year_Result, 
                                        Statut = (s.Year_Result >= 12) ? "OK" : "KO" });

            foreach (var item in queryResult)
            {
                Console.WriteLine($"{item.Last_Name} - {item.Year_Result} - {item.Statut}");
            }*/

            /*3.3
            var queryResult = dc.Students
                                    .Where((s) => s.Last_Name.EndsWith("r"))
                                    .Select((s)=> new { s.Last_Name, s.Section_ID });

            foreach (var item in queryResult)
            {
                Console.WriteLine($"{item.Last_Name} - {item.Section_ID}");
            }*/

            /*3.4
            var queryResult = dc.Students
                                    .Where((s) => s.Year_Result <= 3)
                                    .Select((s) => new { s.Last_Name, s.Year_Result})
                                    .OrderByDescending((s) => s.Year_Result);

            foreach (var item in queryResult)
            {
                Console.WriteLine($"{item.Last_Name} - {item.Year_Result}");
            }
            */

            /*3.6
            var queryResult = dc.Students
                                    .Where((s) => s.Section_ID == 1010 || s.Section_ID == 1020)
                                    .Where((s) => s.Year_Result <12 || s.Year_Result > 18)
                                    .Select((s)=> new { 
                                        Nom = s.Last_Name, 
                                        Section = s.Section_ID, 
                                        ResultatAnnuel = s.Year_Result })
                                    .OrderBy((s)=> s.Section);

            foreach (var item in queryResult)
            {
                Console.WriteLine($"{item.Nom} - {item.Section} - {item.ResultatAnnuel}");
            }*/

            /*3.7
            var queryResult = dc.Students
                                    .Where((s) => s.Section_ID.ToString().StartsWith("13"))
                                    .Select((s) => new
                                    {
                                        s.Last_Name,
                                        s.Section_ID,
                                        Result_100 = (s.Year_Result * 100) / 20
                                    })
                                    .Where((s)=>s.Result_100 <= 60)
                                    .OrderByDescending((s) => s.Result_100);

            foreach (var item in queryResult)
            {
                Console.WriteLine($"{item.Last_Name} - {item.Section_ID} - {item.Result_100}");
            }
            
            */
            /** DEMO CROSS-JOIN
            var queryResult = dc.Students
                                    .Join(dc.Sections,
                                        stud => 1,
                                        sect => 1,
                                        (stud, sect) => new { stud.Last_Name, stud.First_Name, sect.Section_Name }
                                    );

            foreach (var item in queryResult)
            {
                Console.WriteLine($"{item.Last_Name} {item.First_Name} : {item.Section_Name}");
            }*/

            /*4.1
            double moyenne = dc.Students.Average(s => s.Year_Result);

            Console.WriteLine($"La moyenne est de {moyenne}.");
            */

            /*4.2
            int max_result = dc.Students.Max(s => s.Year_Result);

            Console.WriteLine($"La côte maximum est de {max_result}.");
            */

            /*4.3
            int sum_result = dc.Students.Sum(s => s.Year_Result);

            Console.WriteLine($"La somme des côtes est de {sum_result}.");
            */

            /*4.4
            int min_result = dc.Students.Min(s => s.Year_Result);

            Console.WriteLine($"La côte minimum est de {min_result}.");
            */

            /*4.5
            int nbr_stud = dc.Students.Count(s => s.Year_Result % 2 == 1);

            Console.WriteLine($"Le nombre d'étudiants ayant eu un résultat impair est de {nbr_stud}.");
            */


            #endregion

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}