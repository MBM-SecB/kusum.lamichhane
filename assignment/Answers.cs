using System;

class Answers

{
    internal bool Sum()

    {
        Console.Write("enter the firstNum");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("enter the secondNumber");
        int secondNum = int.Parse(Console.ReadLine());

        if (firstNum + secondNum > 500)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    internal int Points()
    {
        Console.WriteLine("enter the number of wins");
        int wins = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the number of draws");
        int draws = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the number of losses");
        int losses = int.Parse(Console.ReadLine());
        return wins * 5 + draws * 2 + losses * 0;
    }
    internal string GetInitials(string name)
    {
        string initials = "";
        initials += name[0];
        for (int i = 0; i < name.Length - 1; i++)
        {
            if (name[i] == ' ')
            {
                initials = initials + name[i + 1];

            }

        }
        return initials.ToUpper();
    }


}

