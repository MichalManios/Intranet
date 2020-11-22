using System;
using HtmlAgilityPack;
using System.Xml;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ASdatabase;
using Areszt_Śledczy_w_Łodzi.Services;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi
{
    public class LoadOldZarzadzenia : ILoadOldZarzadzenia
    {
        string number = "0";
        string year = "0";
        string path = @"C:\inetpub\publish\wwwroot\OldZarzadzeniaWeb\";
        List<Zarzadzenie> zarzadzenies;
        private readonly IZarzadzenieRepository zarzadzenieRepository;
        public bool bEndSave = false;

        public LoadOldZarzadzenia(IZarzadzenieRepository repository)
        {
            zarzadzenieRepository = repository;
        }
        public async Task<bool> Load(string NameOfFile, bool bActual)
        {
            var path2 = path + NameOfFile;
            HtmlDocument doc = new HtmlDocument();
            doc.Load(path2, Encoding.GetEncoding("windows-1250"));
            List<string> NoZarzadzenia = new List<string>();
            zarzadzenies = new List<Zarzadzenie>();
            List<HtmlNode> htmlNode = doc.DocumentNode.SelectNodes("//a").ToList();

            zarzadzenies.Clear();
            foreach (var item in htmlNode)
            {
                if (item.InnerText != "")
                {
                    var zarzadzenie = Regex.Replace(item.InnerText, @"\r\n", " ");
                    if (zarzadzenie.Length > 6)
                    {
                        if (zarzadzenie.IndexOf('/') < 2)
                        {
                            number = zarzadzenie.Substring(0, 1);
                            year = zarzadzenie.Substring(2, 4);
                        }
                        else if (zarzadzenie.IndexOf('/') < 3)
                        {
                            number = zarzadzenie.Substring(0, 2);
                            year = zarzadzenie.Substring(3, 4);
                        }
                        else if (zarzadzenie.IndexOf('/') < 4)
                        {
                            number = zarzadzenie.Substring(0, 3);
                            year = zarzadzenie.Substring(4, 4);
                        }
                        else
                        {
                            number = "0";
                            year = "0";
                            //NoZarzadzenia.Add(zarzadzenie);
                        }
                    }
                    if (CheckNumber(number) == true && CheckYear(year) == true && year != "0")
                    {
                        if (zarzadzenie.Count() > number.Count() + year.Count() + 1)
                        {
                            if (bActual)
                            {
                                zarzadzenies.Add(new Zarzadzenie
                                {
                                    Actual = true,
                                    Number = Convert.ToInt32(number),
                                    Year = Convert.ToInt32(year),
                                    ContentOfDirective = zarzadzenie.Remove(0, number.Count() + year.Count() + 1).ToString()
                                });
                            }
                            else
                            {
                                zarzadzenies.Add(new Zarzadzenie
                                {
                                    Actual = false,
                                    Number = Convert.ToInt32(number),
                                    Year = Convert.ToInt32(year),
                                    ContentOfDirective = zarzadzenie.Remove(0, number.Count() + year.Count() + 1).ToString()
                                });
                            }
                        }
                        else NoZarzadzenia.Add(zarzadzenie);
                    }
                    else NoZarzadzenia.Add(zarzadzenie);
                }
            }
            SaveToFileAllNoZarzadzenia(NoZarzadzenia);
            bool end=await SaveAllToDatabase();
            bEndSave = end;
            path2 = "";
            return end;
        }

        public async Task<bool> SaveAllToDatabase()
        {
            return await zarzadzenieRepository.SaveMany(zarzadzenies);
        }

        public void SaveToFileAllNoZarzadzenia(List<string> NoZarzadzenia)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\inetpub\publish\wwwroot\OldZarzadzeniaWeb\NoZarzadzeniaList.txt", true))
            {
                file.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (string line in NoZarzadzenia)
                {
                    file.WriteLine(line);
                    file.WriteLine(" ");
                }
                file.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                file.WriteLine(" ");
            }
        }

        public bool CheckNumber(string number)
        {
            int x = 0;
            foreach (var item in number)
            {
                if (item == '0' || item == '1' || item == '2' || item == '3' || item == '4' || item == '5' ||
                    item == '6' || item == '7' || item == '8' || item == '9')
                {
                    x++;
                }
            }
            if (x == number.Count()) return true;
            else return false;
        }
        public bool CheckYear(string Year)
        {
            int x = 0;
            foreach (var item in Year)
            {
                if (item == '0' || item == '1' || item == '2' || item == '3' || item == '4' || item == '5' ||
                    item == '6' || item == '7' || item == '8' || item == '9')
                {
                    x++;
                }
            }
            if (x == Year.Count()) return true;
            else return false;
        }
    }
}
