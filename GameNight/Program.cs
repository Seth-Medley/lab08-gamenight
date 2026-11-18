/*
* Name: Seth Medley
* Course: CSCI 1250, Section 001
* Assignment: Lab 08, Game Night
* Date: November 18, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/
using System.Drawing;
using System.Runtime.InteropServices;

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

string projectFolder = Path.GetFullPath(
Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] insertPlayersFile = File.ReadAllLines(PLAYERS_FILE);
string[] insertPointsFile = File.ReadAllLines(POINTS_FILE);
string[] insertHistoryFile = File.ReadAllLines(HISTORY_FILE);

Console.Write("PLAYER".PadRight(11));
Console.WriteLine("POINTS");
for (int i = 0; i < insertPlayersFile.Length; i++) {
    Console.Write(insertPlayersFile[i].PadRight(11));
    Console.WriteLine(insertPointsFile[i]);
}
int leaderPoints = LeaderIndex(insertPointsFile);
int totalPoints = TotalPoints(insertPointsFile);
Console.WriteLine($"Leader: {insertPlayersFile[leaderPoints]} with {insertPointsFile[leaderPoints]}");
Console.WriteLine($"Season total: {totalPoints}");



static int LeaderIndex(string[] points)
{
    int convertPoints = Convert.ToInt32(points[0]);
    int leaderIndex = 0;
    int highestPoint = Convert.ToInt32(points[0]);
    for (int i = 0; i < points.Length; i++) {
        Convert.ToInt32(points[i]);
        int currentPoints = Convert.ToInt32(points[i]);
        if (currentPoints > highestPoint)
        {
            leaderIndex = i;
            highestPoint = currentPoints;
        }
    }
        return leaderIndex;
}
static int TotalPoints(string[] points)
{
    int total = 0;
    foreach (var item in points)
    {
        int convert = Convert.ToInt32(item);
        total = total + convert;
    }
    return total;
}
static string HistoryEntry(int night, string winner, int points)
{


    return Convert.ToString(night);
    return Convert.ToString(winner);
    return Convert.ToString(points);
}