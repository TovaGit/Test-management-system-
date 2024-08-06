using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public class GetFromJson
    {
        public List<Test> GetFromTestJson()
        {
            string jsonTest = "";

            List<Test> existDataTest;
            try
            {
                jsonTest = File.ReadAllText("tests.json");
            }
            catch
            {
                MessageBox.Show("Sorry not able to find this file: question.json");
            }
            existDataTest = JsonConvert.DeserializeObject<List<Test>>(jsonTest);
            return existDataTest;
        }
        public List<Question> GetFromQuestionJson()
        {
            string jsonQuestion = "";

            List<Question> existDataQuestion;
            try
            {
                jsonQuestion = File.ReadAllText("question.json");
            }
            catch
            {
                MessageBox.Show("Sorry not able to find this file: question.json");
            }
            existDataQuestion = JsonConvert.DeserializeObject<List<Question>>(jsonQuestion);
            return existDataQuestion;
        }
    }
}
