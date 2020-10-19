using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace QandA.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly string _connectionString;

        public DataRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        public AnswerGetResponse GetAnswer(int answerId)
        {
            throw new System.NotImplementedException();
        }

        public QuestionGetSingleResponse GetQuestion(int questionId)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<QuestionGetManyResponse> GetQuestions()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection.Query<QuestionGetManyResponse>(@"EXEC dbo.Question_GetMany");
        }

        public System.Collections.Generic.IEnumerable<QuestionGetManyResponse> GetQuestionsBySearch(string search)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<QuestionGetManyResponse> GetUnansweredQuestions()
        {
            throw new System.NotImplementedException();
        }

        public bool QuestionExists(int questionId)
        {
            throw new System.NotImplementedException();
        }
    }
}
