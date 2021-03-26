using GameQuiz.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GameQuiz.Repository
{
    public class QuizHandller
    {
        private SqlConnection con;

        //To Handle connection related activities
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);
        }

        public List<QuizModel> GetAllEasyQuestions()
        {
            connection();
            List<QuizModel> EmpList = new List<QuizModel>();

            SqlCommand com = new SqlCommand("getEasyQuizData", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind QuizModel generic list using dataRow
            foreach (DataRow dr in dt.Rows)
            {
                EmpList.Add(
                    new QuizModel
                    {
                        id = Convert.ToInt32(dr["id"]),
                        Question = Convert.ToString(dr["question"]),
                        Option1 = Convert.ToString(dr["option1"]),
                        Option2 = Convert.ToString(dr["option2"]),
                        Option3 = Convert.ToString(dr["option3"]),
                        Option4 = Convert.ToString(dr["option4"])
                    }
                    );
            }

            return EmpList;
        }

        public List<QuizModel> GetAllMediumQuestions()
        {
            connection();
            List<QuizModel> EmpList = new List<QuizModel>();

            SqlCommand com = new SqlCommand("getMediumQuizData", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind QuizModel generic list using dataRow
            foreach (DataRow dr in dt.Rows)
            {
                EmpList.Add(
                    new QuizModel
                    {
                        id = Convert.ToInt32(dr["id"]),
                        Question = Convert.ToString(dr["question"]),
                        Option1 = Convert.ToString(dr["option1"]),
                        Option2 = Convert.ToString(dr["option2"]),
                        Option3 = Convert.ToString(dr["option3"]),
                        Option4 = Convert.ToString(dr["option4"])
                    }
                    );
            }

            return EmpList;
        }

        public List<QuizModel> GetAllHardQuestions()
        {
            connection();
            List<QuizModel> EmpList = new List<QuizModel>();

            SqlCommand com = new SqlCommand("getHardQuizData", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind QuizModel generic list using dataRow
            foreach (DataRow dr in dt.Rows)
            {
                EmpList.Add(
                    new QuizModel
                    {
                        id = Convert.ToInt32(dr["id"]),
                        Question = Convert.ToString(dr["question"]),
                        Option1 = Convert.ToString(dr["option1"]),
                        Option2 = Convert.ToString(dr["option2"]),
                        Option3 = Convert.ToString(dr["option3"]),
                        Option4 = Convert.ToString(dr["option4"])
                    }
                    );
            }

            return EmpList;
        }
    }
}