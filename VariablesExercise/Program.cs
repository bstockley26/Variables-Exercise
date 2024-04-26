namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            string dogName;
            dogName = "Nora";

            int dogAge;
            dogAge = 3;

            char middleInitial = 'R';

            bool yes = true;

            double weight = 45;

            decimal foodPrice = 20;

            string dogBreed = "German Shorthaired Pointer";


            Console.WriteLine($"My dogs name is {dogName} and she is {dogAge} years old. She is a {dogBreed}");

            Console.WriteLine($"{dogName} weights {weight} pounds.I spemd {foodPrice} dollars for her food");
        }
    }
}
