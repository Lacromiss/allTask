using System;

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username:");
            string username = Console.ReadLine();

            string password;
            do
            {
                Console.WriteLine("Passwd:");
                password = Console.ReadLine();
            } while (!User.PasswordChecker(password));

            int role;
            bool isNum;
            do
            {
                Console.WriteLine("Role (1. Admin, 2. Member):");
                string roleStr = Console.ReadLine();
                isNum = int.TryParse(roleStr, out role);
            } while (!isNum || !Enum.IsDefined(typeof(Role), role));

            User user = new User(username, password, (Role)role);

            Department department = new Department(3);

            bool check = true;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Get employee by id");
                Console.WriteLine("3. Get all employee");
                Console.WriteLine("0. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (user.Role == Role.Admin)
                        {
                            Console.WriteLine("Ad:");
                            string name = Console.ReadLine();

                            double salary;
                            bool isDouble;
                            do
                            {
                                Console.WriteLine("Salary:");
                                string salaryStr = Console.ReadLine();
                                isDouble = double.TryParse(salaryStr, out salary);
                            } while (!isDouble);

                            Employee employee = new Employee(name, salary);

                            department.AddEmployee(employee);
                        }
                        else
                        {
                            Console.WriteLine("admin deyilsen sen qaqulya");
                        }
                        break;
                    case "2":
                        int id = Convert.ToInt32(Console.ReadLine());

                        department.GetEmployeeById(id).ShowInfo();
                        break;
                    case "3":
                        foreach (var item in department.GetAllEmployees())
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("sehvlik var");
                        break;
                }
            } while (check);

        }
    }
}