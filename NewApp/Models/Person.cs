 public void Export()
        {
            Console.WriteLine("{0} - {1} Tuoi - ID: {2}", FullName , Age, PersonID);
        }   
        public void Export2(string FullName, int Age)
        public void Export(string FullName, int Age)
        {
            Console.WriteLine("{0} - {1} Tuoi", FullName , Age);
        }
        public void Export(string FullName, string PersonID)
        {
            Console.WriteLine("{0} - can cuoc so: {1} ", FullName , PersonID);
        }
    }
}