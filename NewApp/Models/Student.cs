namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public string StudentID {get; set;}
        public Students ()
        {
            Name = "Phung Xuan Duc";
            Address ="Vinh Phuc";
            StudentID ="2021050214";
        }
        public int GetYearOfBirth(int age)
    {
        int yearOfBirth = 2023-age;
        return yearOfBirth;
    }   
 }
 }