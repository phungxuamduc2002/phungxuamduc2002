 public class Program

    private static void Main(string[] args)
        /*  StudentBT[] stdArray = new StudentBT[2];
         // Nhap thong tin
         for (int i = 0; i < stdArray.Length; i++)
         {
      System.Console.WriteLine("Nhap phan tu thu " + i);
             StudentBT std = new StudentBT();
             std.EnterData();
             stdArray[i] = std;
         }
         // Hien thi thong tin
         for (int i = 0; i < stdArray.Count(); i++) ;
         {
             System.Console.Write(stdArray[i] + "\t");
         }
         foreach (StudentBT std in stdArray)
         {
             string ID = std.StudentID;
             string Name = std.StudentName;
             int Age = std.Age;
             System.Console.WriteLine(ID + Name + Age);
         }
         //Them thong tin 
         StudentBT newStudent = new StudentBT();
         AddNewStudent(ref stdArray, ); */



        //BT ArrayList
        ArrayList StudentList = new ArrayList();
        System.Console.WriteLine("Nhap so luong sinh vien muon them: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        StudentBT[] stdArray = new StudentBT[2];
        // Nhap thong tin
        for (int i = 0; i < stdArray.Length; i++)
        {
            System.Console.WriteLine("\n Sinh vien thu: " + (i + 1));
            System.Console.WriteLine("Nhap phan tu thu " + i);
            StudentBT std = new StudentBT();
            std.EnterData();
            StudentList.Add(std);
            stdArray[i] = std;
        }
        System.Console.WriteLine($"\n Thong tin cac sinh vien trong danh sach:");
        foreach (StudentBT std in StudentList)
        // Hien thi thong tin
        for (int i = 0; i < stdArray.Count(); i++) ;
        {

            System.Console.WriteLine($"ID: {std.StudentID}, Name: {std.StudentName}, Tuoi: {std.Age}");
            System.Console.Write(stdArray[i] + "\t");
        }
        foreach (StudentBT std in stdArray)
        {
            string ID = std.StudentID;
            string Name = std.StudentName;
            int Age = std.Age;
            System.Console.WriteLine(ID + Name + Age);
        }


        /* //Them thong tin 
        StudentBT newStudent = new StudentBT();
        AddNewStudent(ref stdArray, );
 */



    }