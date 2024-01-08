using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Financial_Tracker
{
    abstract class transaction
    {
        public decimal amount { get; set; }
        public String description { get; set; }
        public abstract void display_transtion();
    }
     class Income : transaction
    {
        public override void display_transtion()
        {
            Console.WriteLine($"Income : {amount} ({description})");
        }
    }
    class expense : transaction { 
        public String category {  get; set; }
        public override void display_transtion()
        {
            Console.WriteLine($"Expense : {amount} \n {category}:{description}");
        }
    }
  
    class budgetlimit
    {
        public String category_name { get; set; }
        public decimal budget_limit {  get; set; }
        public void displpay_budget_category()
        {
            Console.WriteLine($"Category : {category_name} \n" +
                $"Budget Limit :{budget_limit}");
        }
    }
    class Financial_profile
    {
        public List<transaction> Transtions { get; set; }
        public List<budgetlimit> bg {  get; set; }
        public Financial_profile()
        {
            Transtions=new List<transaction>();
            bg=new List<budgetlimit>();
        }
        public void addtransaction(transaction transaction)
        {
            Transtions.Add(transaction);
        }
        public void addbudget(budgetlimit budgetlimit)
        {
            bg.Add(budgetlimit);
        }
        public void displayfinaacialprofile()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Financial Profile");
            foreach(var transaction in Transtions)
            {
                transaction.display_transtion();
            }
            Console.WriteLine() ;
            Console.WriteLine("Budget Overview");
            foreach(var budget in bg)
            {
                budget.displpay_budget_category();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Financial_profile fp=new Financial_profile();
            Console.WriteLine("*** PERSONAL FINANCIAL TRACKER ***");
            Income income=new Income();
            Console.WriteLine("Enter the income information");
            Console.WriteLine();
            Console.Write("Enter the amount : ");
            income.amount=decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the description : ");
            income.description=Console.ReadLine();
            Console.WriteLine();
            fp.addtransaction(income);

            expense expense=new expense();
            Console.WriteLine("Enter the expense details");
            Console.WriteLine();
            Console.Write("Enter the amount : ");
            expense.amount=decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the description : ");
            expense.description=Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the category : ");
            expense.category=Console.ReadLine();
            Console.WriteLine();
            fp.addtransaction(expense);

            budgetlimit bl=new budgetlimit();
            Console.Write("Enter the category name : ");
            bl.category_name=Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the budget limit : ");
            bl.budget_limit=decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            fp.addbudget(bl);

            fp.displayfinaacialprofile();
            Console.ReadKey();
        }
    }
}
