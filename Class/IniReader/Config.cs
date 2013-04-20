﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IniReader
{
    public class Config
    {
        private readonly IDictionary<string, ConfigSection> _sections;

        public Config(IEnumerable<ConfigSection> sections)
        {
            this._sections = sections.ToDictionary(c => string.Format("{0}|{1}", c.Section, c.Name ?? string.Empty), StringComparer.InvariantCultureIgnoreCase);
        }

        public ConfigSection this[string section]
        {
            get { return GetSection(section); }
        }

        public ConfigSection this[string section, string name]
        {
            get { return GetSection(section, name); }
        }

        public ConfigSection GetSection(string sectionName, string name = null)
        {
            var nameToSearch = string.Format("{0}|{1}", sectionName, name ?? String.Empty);
            ConfigSection section;
            _sections.TryGetValue(nameToSearch, out section);
            return section;
        }

        public void Save(string filename)
        {
            using (var sw = new StreamWriter(filename))
            {
                foreach (var section in _sections)
                {
                    var sec = section.Key.Split('|');

                    sw.WriteLine("[" + sec[0] + (sec.Count() > 1 && !string.IsNullOrEmpty(sec[1]) ? " \"" + sec[1] + "\"" : "") + "]");

                    foreach (var atr in section.Value.Attributes)
                    {
                        sw.WriteLine(atr.AttributeName + "=" + atr.Value);
                    }
                }
            }
        }
    }
}