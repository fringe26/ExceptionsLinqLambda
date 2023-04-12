namespace ExceptionLinqLamba;

public class Program
{
    
    static void Main(string[] args)
    {
        #region Lambda Anonymous
        //Func<int, int> findEvens = delegate (int x)
        //{
        //    if (x % 2 == 0)
        //    {
        //        return x;
        //    }
        //    return -1;
        //};
        //MyMethod(findEvens);


        //Predicate<int> IsEven = delegate (int x)
        //{
        //    return (x % 2 == 0);
        //};

        //if (Filter(x =>  x > 10 ))
        //{
        //    Console.WriteLine("Bigger than 10");
        //}
        //else
        //{
        //    Console.WriteLine("Odd");
        //}

        #endregion

        #region LINQ
        //List<int> listInts = new List<int>()
        //{
        //    1,2,3,4,5,6,7,8,89,90,0,5,6,43,5,546,546,57,34534,5,56,435,35
        //};


        //var newList = listInts.Where(n => n % 2 == 0).OrderBy(n => n).Skip(3).Take(4);

        //PrintList(newList);


        List<Student> students = new List<Student>
        {
            new Student(1,"Jale"),
            new Student(2,"Efsane"),
            new Student(3,"Izzat"),
            new Student(4,"Samir"),
            new Student(5,"Faiq"),
            new Student(6,"Elmira"),
            new Student(7,"Jale")

        };
        
     


        


        //string password = "Salam434@^#";
        //var checkNumber = password.Any(c=>char.IsDigit(c));
        //var checkUpperCase = password.Any(c => char.IsUpper(c));
        //var checkSymbol = password.Any(c => !char.IsLetter(c) && !char.IsDigit(c));

        //password.

        //if(checkNumber && checkUpperCase && checkSymbol)
        //{
        //    Console.WriteLine("Password teleblere uygundu");
        //}
        //else
        //{
        //    Console.WriteLine("Uygun deyil");
        //}


        //PrintList(linqList);

        #endregion


    }


    public static Student FirstOrDefaultCustom(List<Student> studentsList,Predicate<Student> predicate)
    {
        Student student = default;

        try
        {
            student = studentsList.First(s => predicate(s));
            return student;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }

        return student;
    }

    public static void PrintList<T>(IEnumerable<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    public static bool Filter(Predicate<int> predicate) => predicate(30);
   
    public static void MyMethod(Func<int, int> method)
    {
        int? result = method?.Invoke(15);
        Console.WriteLine(result);
    }
}

public class Student 
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"Id: {Id}\n" +
            $"Name: {Name}";
    }
}
