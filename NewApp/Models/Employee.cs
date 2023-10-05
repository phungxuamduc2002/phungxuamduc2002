 public void ImportData()
        }
        public void ExportData()
        {
            Console.WriteLine("Thong tin nhan vien: \n Ong/ba : {0} \n Tuoi : {1} \n Ma Nhan Vien: {2} \n Muc luong hien tai: {3} VND", NameOfEmp , AgeOfEmp , EmpID , Salary);
            Console.WriteLine("Thong tin nhan vien: \n Ong/ba : {0} \n Tuoi : {1} \n Ma Nhan Vien: {2} \n Muc luong hien tai: {3} USD", NameOfEmp , AgeOfEmp , EmpID , Salary);
        }

        public Employee()
        {
            NameOfEmp ="Phung Xuan Duc";
            AgeOfEmp = 21;
            EmpID = 110701;
            Salary = 2002;
        }
    }
}