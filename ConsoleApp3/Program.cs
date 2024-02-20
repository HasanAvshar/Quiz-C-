Quiz();

void Quiz()
{
    string[,] questions = new string[,]
    {
        {"Azerbaycanin paytaxti haradi?","A) Naxcivan","B) Baki","C) Qebele","D) Quba","B"},
        { "Dunyanan en boyuk okeani hansidir?", "A) Atlantika okean?", "B) Hind okean?", "C) Pasifik okean?", "D) C?nubi okean", "C"},
        { "C# dilində mətnləri ekrana çap edən əməliyyat hansıdır?", "A) Console.WriteLine", "B) Console.ReadLine", "C) Console.Write", "D) Console.Read", "A"},
        { "Aşağıdakılardan hansı proqramlaşdırma dilinə aid deyil?", "A) C#", "B) Java", "C) Python", "D) HTML", "D"},
        { "Dövr operatorları hansılardır?", "A) for, while, foreach", "B) begin, end", "C) start, stop", "D) repeat, until", "A"},
        { "Aşağıdakı operatorlardan hansı dövr əmri verir?", "A) continue", "B) break", "C) return", "D) exit", "B"},
        { "Aşağıdakılardan hansı dəyişən adıdır?", "A) 1variable", "B) _variable", "C) #variable", "D) $variable", "B"},
        { "İstifadəçidən məlumat almaq üçün hansı funksiya istifadə olunur?", "A) get", "B) read", "C) input", "D) scan", "C"},
        { "Aşağıdakı şərt operatorları hansıdır?", "A) and, or, not", "B) &&, ||, !", "C) &, |, ~", "D) and, or", "B" },
        {"Vurma isaresi hansidi","A) /","B) +","C) -","D) *","D"}
    };


    int correct_count = 0;
    int wrong_count = 0;

    Random rnd = new Random();
    int n = questions.GetLength(0);
    while (n > 1)
    {
        n--;
        int k = rnd.Next(n + 1);
        string[] temp = new string[6];
        for (int i = 0; i < 6; i++)
        {
            temp[i] = questions[k, i];
            questions[k, i] = questions[n, i];
            questions[n, i] = temp[i];
        }
    }

    for (int i = 0; i < questions.GetLength(0); i++)
    {
        string question = questions[i, 0];
        string optionA = questions[i, 1];
        string optionB = questions[i, 2];
        string optionC = questions[i, 3];
        string optionD = questions[i, 4];
        string correctAnswer = questions[i, 5];
       Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Sual {i + 1}: {question}");
        Console.WriteLine($"{optionA}");
        Console.WriteLine($"{optionB}");
        Console.WriteLine($"{optionC}");
        Console.WriteLine($"{optionD}");

        int selected = 1;
        ConsoleKeyInfo info;
        do
        {
            info = Console.ReadKey(true);
            if (info.Key == ConsoleKey.UpArrow)
            {
                if (selected == 1) selected = 4;
                else selected--;
            }
            else if (info.Key == ConsoleKey.DownArrow)
            {
                if (selected == 4) selected = 1;
                else selected++;
            }
     

            Console.SetCursorPosition(0, Console.CursorTop - 4);
            switch (selected)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{optionA}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{optionB}");
                    Console.WriteLine($"{optionC}");
                    Console.WriteLine($"{optionD}");
                    break;
                case 2:
                    Console.WriteLine($"{optionA}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{optionB}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{optionC}");
                    Console.WriteLine($"{optionD}");
                    break;
                case 3:
                    Console.WriteLine($"{optionA}");
                    Console.WriteLine($"{optionB}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{optionC}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{optionD}");
                    break;
                case 4:
                    Console.WriteLine($"{optionA}");
                    Console.WriteLine($"{optionB}");
                    Console.WriteLine($"{optionC}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{optionD}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        } while (info.Key != ConsoleKey.Enter);

        string userAnswer = "";
        switch (selected)
        {
            case 1:
                userAnswer = "A";
                break;
            case 2:
                userAnswer = "B";
                break;
            case 3:
                userAnswer = "C";
                break;
            case 4:
                userAnswer = "D";
                break;
        }

        if (userAnswer == correctAnswer)
        {
            correct_count++;
        }
        else
        {
            wrong_count++;
        }

        Console.Clear();
    }

    Console.WriteLine("Score: ");
    Console.WriteLine("Correct count: " + correct_count);
    Console.WriteLine("Wrong count: " + wrong_count);

}