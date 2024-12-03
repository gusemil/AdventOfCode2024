using AdventOfCode2024_Day2;

Console.WriteLine("Advent of Code 2024 Day 2!");

int safeReports = 0;

//var reports = InitReports.InitAndReturnExampleReports();
var reports = InitReports.InitAndReturnReports();

for (int i=0; i<reports.Count; i++)
{
    safeReports += CheckLevelSafety(reports[i], true, true);
}


Console.WriteLine("Safe reports amount: " + safeReports);


int CheckLevelSafety(List<int> inReport, bool writeResult = false, bool writeLogs = false)
{
    int lastResult = 0;
    for (int i = 0; i < inReport.Count - 1; i++)
    {
        int increasing = 0;
        if (inReport[i] < inReport[i + 1])
        {
            if(i > 0 && lastResult != 1)
            {
                if (writeResult) Console.WriteLine("UNSAFE");
                return 0;
            }
            //Increasing
            increasing = 1;
            if (writeLogs) Console.WriteLine(inReport[i] + " VS " + inReport[i +1] + " INCREASING");
        }
        else if (inReport[i] > inReport[i + 1])
        {
            if (i > 0 && lastResult != -1)
            {
                if (writeResult) Console.WriteLine("UNSAFE");
                return 0;
            }
            //Decreasing
            increasing = -1;
            if (writeLogs) Console.WriteLine(inReport[i] + " VS " + inReport[i + 1] + " DECREASING");
        }
        else
        {
            //Stale
            if (writeResult) Console.WriteLine("STALE UNSAFE");
            return 0;
        }

        lastResult = increasing;

        int difference = Math.Abs(inReport[i] - inReport[i + 1]);
        if (difference > 3 || difference == 0)
        {
            if (writeResult) Console.WriteLine("UNSAFE");
            return 0;
        }
    }

    if (writeResult) Console.WriteLine("SAFE");
    return 1;
}