using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Practise_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1 
            //var account = new BankAccount(100);
            //account.Deposit(50);
            //account.Withdraw(200);

            //Question 2
            //var stu = new Student("ritvi", 12);
            //stu.Display();

            //Question 3 
            //var lib = new Library_System();
            //var lib1 = new Library_System("book", "author");
            //var lib2 = new Library_System("book", 1234);

            //Question 4
            //var circle = new circle(21.0);
            //Console.WriteLine(circle.CalculateArea());
            //var rectangle = new rectangle(1.2, 2);
            //Console.WriteLine(rectangle.CalculateArea());

            //Question 5
            //var vehicle = new vehicle();
            //var car = new car();
            //var bike = new bike();
            //vehicle.start();
            //car.start();
            //bike.start();

            //Question 6
            //var per1 = new Person("ritvik", 12);
            //var per2 = new Stu("rp", 12, 1, 5);
            //var per3 = new Teacher("r1", 22, "maths");
            //Console.WriteLine(per1.getDetails());
            //Console.WriteLine(per2.getDetails());
            //Console.WriteLine(per3.getDetails());

            //Question 7
            //var nums = new calculator();
            //Console.WriteLine(nums.add(5,8));
            //Console.WriteLine(nums.add(5,2,3));
            //Console.WriteLine(nums.add(5.5,8.2));

            //Question 8
            //var play1 = new MusicPlayer();
            //play1.play();
            //var play2 = new videoPlayer();
            //play2.play();

            //Question 9 
            //report report = new report("This is an important report.");

            //Console.WriteLine("Using IPrintable:");
            //report.print();
            //string filename = "report.txt";
            //report.savetofile(filename);
            //if (File.Exists(filename))
            //{
            //    Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
            //    Console.WriteLine($"Opened {filename}");
            //}
            //else
            //{
            //    Console.WriteLine($"File {filename} does not exist.");
            //}

            //question 10
            //var admin = new admin("ritvik");
            //var customer = new customer("rp");
            //admin.access();
            //customer.access();

            //question 11
            //ComplexNumber c1 = new ComplexNumber(3, 4);
            //ComplexNumber c2 = new ComplexNumber(2, 5);

            //ComplexNumber result = c1 + c2;

            //Console.Write("Sum: ");
            //result.Display();

            //Question 12
            //Department dept1 = new Department("IT", "Alice");
            //Console.WriteLine("Original:");
            //dept1.Display();

            //Department shallowCopy = dept1.ShallowCopy();
            //shallowCopy.DeptManager.Name = "Bob"; 
            //Console.WriteLine("\nAfter modifying shallow copy:");
            //dept1.Display();   
            //shallowCopy.Display();

            //Department deepCopy = dept1.DeepCopy();
            //deepCopy.DeptManager.Name = "Charlie"; 
            //Console.WriteLine("\nAfter modifying deep copy:");
            //dept1.Display();   
            //deepCopy.Display();

            //Question13 
            //Bank acc1 = new Bank("Alice", 10000);
            //Bank acc2 = new Bank("Bob", 15000);

            //Console.WriteLine("Before changing interest rate:");
            //acc1.DisplayAccountInfo();
            //acc2.DisplayAccountInfo();

            //Bank.SetInterestRate(6.5);

            //Console.WriteLine("\nAfter changing interest rate:");
            //acc1.DisplayAccountInfo();
            //acc2.DisplayAccountInfo();

            //Question 14
            //SecuritySystem system = new SecuritySystem("1234");

            //Console.WriteLine("Enter security code:");
            //string inputCode = Console.ReadLine();

            //system.Authenticate(inputCode);

            //Quesion 15
            //Button btn = new Button();
            //static void ButtonClickResponse()
            //{
            //    Console.WriteLine("Event Triggered: Button was clicked!");
            //}

            //btn.OnClick += ButtonClickResponse;

            //Console.WriteLine("Press any key to simulate button click...");
            //Console.ReadKey(); 

            //btn.Click();

            //Question 16
            //Console.WriteLine("Enter Vehicle Type (Car/Bike):");
            //string vehicleType = Console.ReadLine();

            //try
            //{
            //    IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
            //    vehicle.Drive(); 
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //question 17
            //ILogger basicLogger = new FileLogger();
            //ILogger timestampLogger = new TimestampLogger(basicLogger);
            //ILogger errorLogger = new ErrorLogger(timestampLogger);

            //Console.WriteLine("Basic Logging:");
            //basicLogger.Log("System started.");

            //Console.WriteLine("\nLogging with Timestamp:");
            //timestampLogger.Log("User logged in.");

            //Console.WriteLine("\nLogging with Timestamp & Error Categorization:");
            //errorLogger.Log("Failed to connect to database.");

            //Question 
            Console.WriteLine("Requesting Singleton Instance...");
            ConfigurationManager config1 = ConfigurationManager.GetInstance();
            config1.ShowConfig();

            Console.WriteLine("\nRequesting Singleton Instance Again...");
            ConfigurationManager config2 = ConfigurationManager.GetInstance();
            config2.ShowConfig();

            Console.WriteLine("\nAre both instances same? " + (config1 == config2));
        }

    }
}
