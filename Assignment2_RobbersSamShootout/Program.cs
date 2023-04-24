//Assignment-2
//Sam Robbers round up Shoot out Problem
//Sample Input:
//Enter No. of Robbers:
//10
//Enter The Robber with whom Sam will start shooting:
//2
//Enter the gap between the robbers:
//3
//Sample Output:
//Target = 2, 1 shots completed
//Target = 6, 2 shots completed
//Target = 10,3 shots completed
//Target = 5, 4 shots completed
//Target = 1, 5 shots completed
//Target = 8, 6 shots completed
//Target = 7, 7 shots completed
//Target = 9, 8 shots completed
//Target = 4, 9 shots completed
//Target = 3, 10 shots completed
//10 shots taken


using System;

Console.WriteLine("Enter the number of robbers:");
int NoofRobbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Robber with whom Sam will start shooting:");
int FirstTarget = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the gap between the robbers:");
int Gap = Convert.ToInt32(Console.ReadLine());

int Target = FirstTarget;
int Present = FirstTarget - 1;
int Shot = 0;

int[] arr = new int[NoofRobbers];
for (int i = 0; i < NoofRobbers; i++)
{
    arr[i] = i + 1;
}

while (NoofRobbers != 0)
{
    if (Present >= NoofRobbers)
    {
        Present = Present % NoofRobbers;
    }
    Console.WriteLine($"Target ={arr[Present]},{++Shot} shots Completed");

    for (int i = Present; i < NoofRobbers - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    NoofRobbers--;
    Present += Gap;
}
Console.WriteLine(Shot + " Shots taken...");