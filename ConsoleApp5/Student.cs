namespace ConsoleApp3
{
    internal class Student
    {
        private string name;
        private int age;
        private string surname;

        private DateTime dateBirthday;

        private string address;
        private bool exam;
        private int phoneNumber;

        public int[] dzArr = new int[10];
        
        Random random = new Random();

        //------------CONSTRUCTORS------------
        public Student()
        {
            for (int i = 0; i < dzArr.Length; i++)
            {
                dzArr[i] = random.Next(2, 12);
            }

            
        }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string surname, string name)
        {
            this.name = name;
            this.surname = surname;
        }
        public Student(string surname, string name, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        //------------SETTERS------------
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetBirthday(int y, int m, int d)
        {
            dateBirthday = new DateTime(y, m, d);
        }
        public void SetAdress(string adress)
        {
            this.address = adress;
        }
        public void SetPhoneNumber(int phonenumber)
        {
            this.phoneNumber = phonenumber;
        }

        //------------GETTERS------------
        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetAdress()
        {
           return address;
        }
        public int GetPhoneNumber()
        {
           return phoneNumber;
        }
        public void SetExam()
        {
            if (random.Next(0, 2) == 0)
                exam = false;
            else exam = true;
            
        }
        public bool GetExam()
        {
            return exam;
        }
        
    }
}
