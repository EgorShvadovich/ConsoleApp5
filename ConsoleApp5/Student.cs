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
        /// <summary>
        /// Конструктор без параметров который рандомным образом заполняет успеваемость студента.
        /// </summary>
       public Student()
        {
            for (int i = 0; i < dzArr.Length; i++)
            {
                dzArr[i] = random.Next(2, 12);
            }

            
        }
        /// <summary>
        /// Конструктор который позволяет поменять имя студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
       public Student(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Конструктор который позволяет поменять имя и фамилию студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        /// <param name="surname">Передача фамилии</param>
        public Student(string surname, string name)
        {
            this.name = name;
            this.surname = surname;
        }
        /// <summary>
        /// Конструктор который позволяет поменять имя и фамилию и возраст студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        /// <param name="surname">Передача фамилии</param>
        /// <param name="age">Передача возраста</param>
        public Student(string surname, string name, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        //------------SETTERS------------
        /// <summary>
        /// Метод который позволяет поменять имя студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        public void SetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Метод который позволяет поменять фамилию студенту
        /// </summary>
        /// <param name="surname">Передача фамилии</param>
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        /// <summary>
        /// Метод который позволяет поменять возраст студенту
        /// </summary>
        /// <param name="age">Передача возраста</param>
        public void SetAge(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// Метод который позволяет поменять дату рождения студенту
        /// </summary>
        /// <param name="year">Передача года</param>
        /// <param name="month">Передача месяца</param>
        /// <param name="day">Передача дня</param>
        public void SetBirthday(int year, int month, int day)
        {
            dateBirthday = new DateTime(year, month, day);
        }
        /// <summary>
        /// Метод который позволяет поменять адрес студенту
        /// </summary>
        /// <param name="adress">Передача адреса</param>
        public void SetAdress(string adress)
        {
            this.address = adress;
        }
        /// <summary>
        /// Метод который позволяет поменять телефонный номер студенту
        /// </summary>
        /// <param name="phonenumber">Передача номера</param>
        public void SetPhoneNumber(int phonenumber)
        {
            this.phoneNumber = phonenumber;
        }
        /// <summary>
        /// Метод который позволяет рандомным образом определить сдал студент экзамен или нет
        /// </summary>
        public void SetExam()
        {
            if (random.Next(0, 2) == 0)
                exam = false;
            else exam = true;

        }

        //------------GETTERS------------
        /// <summary>
        /// Метод который возвращает имя студента
        /// </summary>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Метод который возвращает фамилию студента
        /// </summary>
        public string GetSurname()
        {
            return surname;
        }
        /// <summary>
        /// Метод который возвращает возраст студента
        /// </summary>
        public int GetAge()
        {
            return age;
        }
        /// <summary>
        /// Метод который возвращает адрес студента
        /// </summary>
        public string GetAdress()
        {
           return address;
        }
        /// <summary>
        /// Метод который возвращает телефонный номер студента
        /// </summary>
        public int GetPhoneNumber()
        {
           return phoneNumber;
        }
        /// <summary>
        /// Метод который говорит о том сдал студент экзамен или нет
        /// </summary>
        public bool GetExam()
        {
            return exam;
        }
        
    }
}
