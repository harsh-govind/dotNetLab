// // See https://aka.ms/new-console-template for more information
// using System;

// public class Students
// {
//    public String name;
//    public int roll;
//    public int[] marks = new int[6];
//    public Students()
//    {
//       name = "Unknown";
//       roll = 0;
//    }
//    public Students(String name, int roll, int[] marks)
//    {
//       this.name = name;
//       this.roll = roll;
//       this.marks = marks;
//    }

//    public void display()
//    {
//       Console.WriteLine("Name: " + name);
//       Console.WriteLine("Roll: " + roll);
//       Console.WriteLine("Marks: ");
//       for (int i = 0; i < 6; i++)
//       {
//          Console.WriteLine(marks[i]);
//       }
//    }
//    public void checkPassed()
//    {
//       int count = 0;
//       for (int i = 0; i < 6; i++)
//       {
//          if (marks[i] >= 40)
//          {
//             count++;
//          }
//       }
//       if (count == 6)
//       {
//          Console.WriteLine("Passed");
//       }
//       else
//       {
//          Console.WriteLine("Failed");
//       }
//    }
// }
// public class FibonacciExample
// {
//    public static void Main(string[] args)
//    {
//       int roll;
//       String name;
//       int[] marks = new int[6];
//       Console.WriteLine("Enter name: ");
//       name = Console.ReadLine();
//       Console.WriteLine("Enter roll: ");
//       roll = Convert.ToInt32(Console.ReadLine());
//       Console.WriteLine("Enter marks: ");
//       for (int i = 0; i < 6; i++)
//       {
//          marks[i] = Convert.ToInt32(Console.ReadLine());
//       }

//       Students s1 = new Students(name, roll, marks);
//       s1.display();
//       s1.checkPassed();
//    }
// }
using System;
public class Matrix
{
   public int[,] mat;
   public int m, n;

   public Matrix(int m, int n)
   {
      this.m = m;
      this.n = n;
   }

   public void setMat()
   {
      Console.WriteLine("Enter matrix values:");
      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            int temp = int.Parse(Console.ReadLine());
            mat[i, j] = temp;
         }
      }
   }
   public void getMat()
   {
      Console.WriteLine("Matrix:");
      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            Console.Write(mat[i, j] + " ");
         }
         Console.WriteLine();
      }
   }
   public int sumMat()
   {
      int sum = 0;
      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            sum += mat[i, j];
         }
      }
      return sum;
   }
}
public class Matrix2dExample
{
   public static void Main()
   {
      int m, n;
      m = int.Parse(Console.ReadLine());
      n = int.Parse(Console.ReadLine());

      Matrix mat = new Matrix(m, n);

      mat.setMat();
      mat.getMat();
      int sum = mat.sumMat();

      Console.WriteLine("Matrix sum = " + sum);
   }
}