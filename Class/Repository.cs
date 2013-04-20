using System.Linq;
using IniReader;

namespace ScriptExec.Class
{
    public class Repository
    {
        public string Path;
        public string Username;

        public string Password
        {
            get { return _password; }
            set { _password = value;
                //_ini.GetSection("repository").Attributes.Where(p => p.AttributeName == "password").Select(p => p.Value) = "aaa";
            }
        }

        private Config _ini;
        private string _password;

        public Repository GetRepository(Config ini)
        {
            _ini = ini;
            var repository = ini.GetSection("repository");

            if (repository == null)
            {
                throw new ScriptExecException("Missing repository section in INI file");
            }

            Path = repository.Attributes.Where(p => p.AttributeName == "path").Select(p => p.Value).Single();
            Username = repository.Attributes.Where(p => p.AttributeName == "username").Select(p => p.Value).Single();
            Password = repository.Attributes.Where(p => p.AttributeName == "password").Select(p => p.Value).Single();

            return this;
        }
    }
}