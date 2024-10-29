//// See https://aka.ms/new-console-template for more information



    {
        int[,] grades = new int[3, 2];
        string[] students = new string[3];

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write("Enter the name of student: ");
            students[i] = Console.ReadLine();

            for (int j = 0; j < grades.GetLength(1); j++)
            {
                Console.Write("Enter the score  "); 
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Student Grades:");
       
    }



