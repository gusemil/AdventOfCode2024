using System.Collections.Generic;

namespace AdventOfCode2024_Day2
{
    public static class InitReports
    {
        public static List<List<int>> InitAndReturnReports()
        {
            List<List<int>> listOfReports = new List<List<int>>();

            List<int> report1 = [7, 6, 5, 4, 3];
            List<int> report2 = [1, 2, 7, 8, 9];
            List<int> report3 = [9, 7, 6, 2, 1];
            List<int> report4 = [1, 3, 2, 4, 5];
            List<int> report5 = [8, 6, 4, 4, 1];
            List<int> report6 = [1, 3, 6, 7, 9];

            listOfReports.Add(report1);
            listOfReports.Add(report2);
            listOfReports.Add(report3);
            listOfReports.Add(report4);
            listOfReports.Add(report5);
            listOfReports.Add(report6);

            return listOfReports;
        }
    }
}
