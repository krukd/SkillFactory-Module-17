namespace SkillFactory_Module_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount normalAccount = new NormalAccount() { Balance = 500};
            Calculator.CalculateInterest(normalAccount);
            Console.WriteLine($"{normalAccount.Interest}");

            IAccount salaryAccount = new SalaryAccount() { Balance = 700};
            Calculator.CalculateInterest(salaryAccount);
            Console.WriteLine($"{salaryAccount.Interest}");
        }
    }
}