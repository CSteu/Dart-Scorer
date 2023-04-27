using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartScorer.Untitled
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }
        public int totPoints { get; set; }
        public int totDarts { get; set; }
        public int matchesPlayed { get; set; }

        public User()
        {

        }
        public User(string username, string password, string nickname, int totPoints, int totDarts, int matchesPlayed)
        {
            this.username = username;
            this.password = password;
            this.nickname = nickname;
            this.totPoints = totPoints;
            this.totDarts = totDarts;
            this.matchesPlayed = matchesPlayed;
        }
        public User readData(string usr, string pass)
        {
            string file = "C:\\Users\\Chase\\Source\\Repos\\Dart-Scorer\\Dart Scorer\\db.txt";
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    int currentLineNum = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == usr && parts[1] == pass)
                        {
                            User user = new User(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                            return user;
                        }
                        currentLineNum++;
                    }
                }
            }
            return null;
        }

        public void writeData()
        {
            string file = "C:\\Users\\Chase\\Source\\Repos\\Dart-Scorer\\Dart Scorer\\db.txt";
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                string line = string.Format("{0},{1},{2},{3},{4}, {5}", username, password, nickname, totPoints, totDarts, matchesPlayed);
                sw.WriteLine(line);
            }
        }

        public User getStats(string usr)
        {
            string file = "C:\\Users\\Chase\\Source\\Repos\\Dart-Scorer\\Dart Scorer\\db.txt";
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    int currentLineNum = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == usr)
                        {
                            User user = new User(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                            return user;
                        }
                        currentLineNum++;
                    }
                }
            }
            return null;
        }

        public void updateStats(string usr, int totPoints, int totDarts, int matchesPlayed)
        {
            string file = "C:\\Users\\Chase\\Source\\Repos\\Dart-Scorer\\Dart Scorer\\db.txt";
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == usr)
                    {
                        lines[i] = string.Format("{0},{1},{2},{3},{4},{5}", username, password, nickname, totPoints, totDarts, matchesPlayed);
                        File.WriteAllLines(file, lines);
                        return;
                    }
                }
            }
        }

    }
}
