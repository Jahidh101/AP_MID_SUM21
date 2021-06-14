using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace labtask2.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student s)
        {
            //string query = String.Format("Insert into Products values ('{0}','{1}',{2},{3})", p.Name, p.Description, p.Price, p.Qty);
            string query = "Insert into Students values(@name,@dob,@credit,@cgpa,@dept_id)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@dob", s.DOB);
            cmd.Parameters.AddWithValue("@credit", s.Credit);
            cmd.Parameters.AddWithValue("@cgpa", s.CGPA);
            cmd.Parameters.AddWithValue("@dept_id", s.Dept_Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student p = new Student()
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept_Id = reader.GetInt32(reader.GetOrdinal("Dept_Id")),
                };
                students.Add(p);
            }
            conn.Close();
            return students;
        }
        public Student Get(int id)
        {
            Student s = null;
            string query = $"select * from Students Where ID={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = new Student()
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept_Id = reader.GetInt32(reader.GetOrdinal("Dept_Id")),
                };
            }
            conn.Close();
            return s;
        }
        public void Update(Student s)
        {
            //string query = "Insert into Students values(@name,@dob,@credit,@cgpa,@dept_id)";
            string query = $"Update Students Set Name='{s.Name}', DOB='{s.DOB}', Credit='{s.Credit}', CGPA='{s.CGPA}', Dept_Id='{s.Dept_Id}' Where ID = {s.ID}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //void Delete(student s)
        //{
        //}
    }
}