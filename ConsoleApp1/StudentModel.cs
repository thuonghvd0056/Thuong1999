namespace ConsoleApp1
{
    public class StudentModel
    {
        private const string Server = "localhost";
        private const string DatabaseName = "Cshap";
        private const string UserName = "root";
        private const string password = "";

        public void Save(Student student)
        {
            var cnnString = string.Format($"Server={Server};Database={DatabaseName};Uid={UserName};pwd={password};SslMode=none",
                Server,
                DatabaseName,
                UserName,
                password);
            MySqlConnecttion connecttion = new MySqlConnecttion();
            connecttion.Open();
            MySqlCommand cmd = new MySqlCommand("insert into students (rollNumber, name, email, phone) values(@val1, @val2, @val3, @val4)", connecttion);
            cmd.Parameters.AddWithValues("@val1", "A123");
            cmd.Parameters.AddWithValues("@val2", "xuan dao");
            cmd.Parameters.AddWithValues("@val3", "xuandao@gmail.com");
            cmd.Parameters.AddWithValues("@val4", "0232948329");
            cmd.ExecuteNonQuery();
            connecttion.Close();
            System.Console.WriteLine("Chạy ngay đi !!!");
        }

        public List<Student> GetList()
        {
            var list = new List<Student>();
            return list;
        }
    }
}