using AdventOfCode2024;

Console.WriteLine("Advent of Code 2024 Day 1!");

List<int> leftList = new List<int>();
List<int> rightList = new List<int>();

//InitListsExample(leftList,rightList);
var lists = InitLists.InitAndReturnLists(leftList,rightList);
leftList = lists.Item1;
rightList = lists.Item2;
CompareLists(leftList,rightList);

void CompareLists(List<int> inLeftList, List<int> inRightList)
{
    //Assume both lists are of equal length
    int listsLength = inLeftList.Count;

    //Sort lists
    inLeftList.Sort();
    inRightList.Sort();

    //Calculate Distance
    int totalDistance = 0;
    for (int i = 0; i < listsLength; i++)
    {
        int d = CalculateDistance(inLeftList[i], inRightList[i]);
        totalDistance += d;
    }


    //Calculate Similarity Score
    int similarityScore = 0;
    for(int i=0; i < listsLength; i++)
    {
        similarityScore += CalculateSimilarityScoreForNumber(leftList[i], rightList);
    }

    Console.WriteLine("Total Distance: " + totalDistance);
    Console.WriteLine("Similarity Score: " + similarityScore);
}

int CalculateDistance(int input1, int input2)
{
    int distance = input1 - input2;
    return Math.Abs(distance);
}

int CalculateSimilarityScoreForNumber(int inLeftSideNumberToCalculate, List<int> inRightList)
{
    int similaryScoreForNumber = 0;
    for(int i=0; i < inRightList.Count; i++)
    {
        if(inLeftSideNumberToCalculate == inRightList[i])
        {
            similaryScoreForNumber += inLeftSideNumberToCalculate;
        }
    }

    return similaryScoreForNumber;
}

void InitListsExample(List<int> inLeftList, List<int> inRightList)
{
    inLeftList.Add(3);
    inLeftList.Add(4);
    inLeftList.Add(2);
    inLeftList.Add(1);
    inLeftList.Add(3);
    inLeftList.Add(3);

    inRightList.Add(4);
    inRightList.Add(3);
    inRightList.Add(5);
    inRightList.Add(3);
    inRightList.Add(9);
    inRightList.Add(3);
}