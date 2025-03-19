using System;

namespace cicdGitactionTest.Models
{
    public class CICDResponse
    {
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public CICDResponse(string message)
        {
            Message = message;
            Timestamp = DateTime.Now;
        }
    }
}
