using CommandLine;

namespace ScriptExec.Class
{
    class Options
    {
        [Option('i', "ini", Required = false, DefaultValue = ".\\ScriptExec.ini", HelpText = "Configutration filename")]
        public string IniFile { get; set; }
    }
}
