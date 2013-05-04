using CommandLine;

namespace ScriptExec.Class
{
    /// <summary>
    /// source: http://commandline.codeplex.com/
    /// </summary>
    class Options
    {
        [Option('i', "ini", Required = false, DefaultValue = ".\\ScriptExec.ini", HelpText = "Configutration filename")]
        public string IniFile { get; set; }
    }
}
