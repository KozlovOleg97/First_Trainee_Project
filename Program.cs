namespace Trainee_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.ShowBalance();

            mortgage.HoldOnOneYear();
            mortgage.ShowBalance();

            // Wait 20 years
            int years = 0;
            while (years < 20)
            {
                mortgage.HoldOnOneYear();
                years = years + 1;
            }
            mortgage.ShowBalance();
        }
    }
}