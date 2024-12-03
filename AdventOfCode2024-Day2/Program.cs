Console.WriteLine("Advent of Code 2024 Day 2!");

List<int> report = [7, 6, 5, 4, 3];
List<int> report2 = [1, 2, 7, 8, 9];
List<int> report3 = [9, 7, 6, 2, 1 ];
List<int> report4 = [1, 3, 2, 4, 5 ];
List<int> report5 = [ 8, 6, 4, 4, 1 ];
List<int> report6 = [1, 3, 6, 7, 9 ];

int safeReports = 0;

safeReports += CheckLevelSafety(report,true);
safeReports += CheckLevelSafety(report2,true);
safeReports += CheckLevelSafety(report3,true);
safeReports += CheckLevelSafety(report4,true);
safeReports += CheckLevelSafety(report5,true);
safeReports += CheckLevelSafety(report6,true);

Console.WriteLine("Safe reports amount: " + safeReports);


int CheckLevelSafety(List<int> inReport, bool writeLogs = false)
{
    int totalIncreasing = 0;
    for (int i = 0; i < inReport.Count - 1; i++)
    {
        int increasing = 0;
        if (inReport[i] > inReport[i + 1])
        {
            //Increasing
            increasing = 1;
        }
        else if (inReport[i] < inReport[i + 1])
        {
            //Decreasing
            increasing = -1;
        }

        if(totalIncreasing == 0)
        {
            totalIncreasing = increasing;
        }
        else
        {
            if(totalIncreasing != increasing)
            {
                if(writeLogs) Console.WriteLine("UNSAFE");
                return 0;
            }
        }

        int difference = Math.Abs(inReport[i] - inReport[i + 1]);
        if (difference > 3 || difference == 0)
        {
            if (writeLogs) Console.WriteLine("UNSAFE");
            return 0;
        }
    }

    if (writeLogs) Console.WriteLine("SAFE");
    return 1;
}