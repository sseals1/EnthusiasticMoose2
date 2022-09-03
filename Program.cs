﻿using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    // MooseSays("H I, I'M  E N T H U S I A S T I C !");
    // MooseSays("I really am enthusiastic");
    Console.WriteLine();
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();

    void CanadaQuestion()
    {
        bool isTrue = MooseAsk("Is Canada real?");
        if (isTrue)
        {
            MooseSays("Really? It seems very unlikely");
        }
        else
        {
            MooseSays("I  K N E W  I T !!!");
        }
    }

    void EnthusiasticQuestion()
    {
        bool isEnthusiastic = MooseAsk("Are you enthusiastic?");
        if (isEnthusiastic)
        {
            MooseSays("Yay!!!");
        }
        else
        {
            MooseSays("You should try it!");
        }
    }

    void LoveCSharpQuestion()
    {
        bool doesLoveCSharp = MooseAsk("Do you love C# yet?");
        if (doesLoveCSharp)
        {
            MooseSays("Good job sucking up to your instructor!");
        }
        else
        {
            MooseSays("You will.....oh, yes, you will...");
        }
    }

    void SecretQuestion()
    {
        bool wantsSecret = MooseAsk("Do you want to know a secret?");
        if (wantsSecret)
        {
            MooseSays("ME TOO!!!! I love secrets...tell me one!");
        }
        else
        {
            MooseSays("Oh, no...secrets are the best, I love to share them!");
        }
    }

    bool MooseAsk(string question)
    {
        Console.WriteLine($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();
        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();

        }
        if (answer == "y")
        {
            return true;
        }
        else
        {
            return false;
        }

    }






    void MooseSays(string message)
    {
        Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                    //   |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }
}