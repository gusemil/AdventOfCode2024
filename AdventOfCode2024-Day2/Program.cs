Console.WriteLine("Advent of Code 2024 Day 2!");

List<int> levels = [7, 6, 5, 4, 3];
List<int> levels2 = [1, 2, 7, 8, 9];
List<int> levels3 = [.. new List<int> { 9, 7, 6, 2, 1 }];
List<int> levels4 = [.. new List<int> { 1, 3, 2, 4, 5 }];
List<int> levels5 = [.. new List<int> { 8, 6, 4, 4, 1 }];
List<int> levels6 = [.. new List<int> { 1, 3, 6, 7, 9 }];

CheckLevelSafety(levels);
CheckLevelSafety(levels2);
CheckLevelSafety(levels3);
CheckLevelSafety(levels4);
CheckLevelSafety(levels5);
CheckLevelSafety(levels6);


bool CheckLevelSafety(List<int> inLevels, bool writeLogs = false)
{
    int totalIncreasing = 0;
    for (int i = 0; i < inLevels.Count - 1; i++)
    {
        int increasing = 0;
        if (inLevels[i] > inLevels[i + 1])
        {
            //Increasing
            increasing = 1;
        }
        else if (inLevels[i] < inLevels[i + 1])
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
                return false;
            }
        }

        int difference = Math.Abs(inLevels[i] - inLevels[i + 1]);
        if (difference > 3 || difference == 0)
        {
            if (writeLogs) Console.WriteLine("UNSAFE");
            return false;
        }
    }

    if (writeLogs) Console.WriteLine("SAFE");
    return true;
}