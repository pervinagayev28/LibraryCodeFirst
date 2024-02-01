using ConsoleApp10.Concrets;
using ConsoleApp10.Rpeositories.BaseRepositories;
using ConsoleApp10.Rpeositories.GenericRepositories;
using ConsoleApp10.Rpeositories.SimpleRepositories;
using DbLibrary.Contexts;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //S_CardRepository context = new();
            //S_CardRepository context = new();
            //GenericRepository<Author,int> context = new();
            GenericRepository<Category,int> context = new();
            for (int i = 1; i < 10; i++)
            {
                context.Add(new Category()
                {
                        Name = "Auhtor "+i,

                });
            }
            context.Commit();

            var datas = context.GetAll();
            foreach (var data in datas)
            {

                //Console.WriteLine(data.Student.Name);
                //Console.WriteLine(data.Book.Name);

                Console.WriteLine(data.Name);
                //Console.WriteLine(data.Surname);
            }


        }
    }
}
