using System.Collections.Generic;
using System.IO;
using System.Linq;
using IniReader;

namespace ScriptExec.Class
{
    public class IniHelper
    {
        private Config _ini = null;
        public Repository Repo = new Repository();
        private string _filename;

        public IniHelper(string filename)
        {
            if (File.Exists(filename))
            {
                ReadIni(filename);
            }
            else
            {
                throw new ScriptExecException("INI file not found");
            }
        }

        public void ReadIni(string filename)
        {
            _filename = filename;
            _ini = IniFileReader.LoadFile(filename);

            if (_ini != null)
            {
                Repo.GetRepository(_ini);
            }
        }

        public List<FileInfo> GetScripts()
        {
            if (Repo.Path.StartsWith("\\\\"))
            {
                PinvokeWindowsNetworking.connectToRemote(Repo.Path, Repo.Username, Repo.Password);
            }

            var di = new DirectoryInfo(Repo.Path);

            var files = di.GetFiles("*.bat");

            return new List<FileInfo>(files);
        }

        public ScriptExtras GetScriptExtras(string name)
        {
            var extras = _ini.GetSection(name);

            return new ScriptExtras
                       {
                           Parameters = extras != null && extras.Attributes.Any(p => p.AttributeName == "parameters") ?
                               extras.Attributes.Single(p => p.AttributeName == "parameters").Value : ""
                       };
        }

        public void Save()
        {
            _ini.Save(_filename);
        }
    }
}