namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inferred code snippet
            var answer = 4;
            string response;

            //interpolated code snippet
            if (answer < 9)
            {
                response = $"{answer} is less than nine.";
            }
            else
            {
                response = $"{answer} is greater than or equal to nine";
            }
            // Ternary operator code snippet
            answer = 4;
            response = answer < 9
                ? $"{answer} is less than nine."
                : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
