using System;
using System.Collections.Generic;
using System.IO;

namespace FolderBrowser
{
    public class FileCreator
    {
        const string author = "Herman Berget";

        public string CreateFiles(string mainPath, int numberOfAssignments, string preamblePath)
        {
            try
            {
                MainPage(mainPath, numberOfAssignments, preamblePath);
                Directory.CreateDirectory(mainPath + "/tex");
                SubPages(mainPath, numberOfAssignments);
                FrontPage(mainPath);

                return "Files created successfully";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private void FrontPage(string path)
        {
            string[] lines =
            {
                "\\author{" + author + "}",
                "\\title{Tittel}",
                "\\date{\\today}",
                "\\pagenumbering{gobble}",
                "\\maketitle",
                "\\newpage",
                "\\pagenumbering{arabic}"
            };

            File.WriteAllLines(path + "/tex/Forside.tex", lines);
        }

        private void SubPages(string path, int numberOfAssignments)
        {
            string[] lines =
            {
                "\\documentclass[../Besvarelse.tex]{subfiles}",
                "\\begin{document}",
                "\\part*{Oppgave }",
                "\n",
                "\\end{document}"
            };

            for (int i = 1; i <= numberOfAssignments; i++)
            {
                File.WriteAllLines(path + "/tex/Oppgave-" + i + ".tex", lines);
            }
        }

        private void MainPage(string folderPath, int numberOfAssignments, string preamblePath)
        {
            List<string> lineList = new List<string>(ReadPreamble(preamblePath))
            {
                "\\begin{document}",
                "\\input{./tex/Forside.tex}"
            };

            for (int i = 1; i <= numberOfAssignments; i++)
            {
                string txt = "\\subfile{./tex/Oppgave-" + i + ".tex}";
                lineList.Add(txt);
            }

            lineList.Add("\\end{document}");

            File.WriteAllLines(folderPath + "\\Besvarelse.tex", lineList.ToArray());
        }

        private string[] ReadPreamble(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch
            {
                throw new Exception("Error when reading preamble.");
            }
        }
    }
}
