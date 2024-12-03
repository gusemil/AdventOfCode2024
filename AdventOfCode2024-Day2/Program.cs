using AdventOfCode2024_Day2;

Console.WriteLine("Advent of Code 2024 Day 2!");

int safeReports = 0;

var reports = InitReports.InitAndReturnReports();

for(int i=0; i<reports.Count; i++)
{
    safeReports += CheckLevelSafety(reports[i]);
}


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