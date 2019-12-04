using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AOC_Day1
{
    public class Parser
    {
        private string _path;

        public Parser(string path)
        {
            _path = path;
        }

        public IEnumerable<Module> ParseInput()
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    yield return new Module() { Mass = int.Parse(line) };
                    line = sr.ReadLine();
                }
            }
        }
    }
}
