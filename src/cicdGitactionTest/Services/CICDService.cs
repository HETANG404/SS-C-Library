using System;    
using cicdGitactionTest.Interfaces;


namespace cicdGitactionTest.Services
{
    public class CICDService : ICICDService
    {
        public string GetCICDStatus()
        {
            return $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} !!!---CICD Successful---!!!";
        }
    }
}