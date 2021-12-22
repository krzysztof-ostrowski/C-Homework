Random random = new Random();
int[] randomInputsArray = new int[50];
for (int i = 0; i < 50; i++)
{
    randomInputsArray[i] = random.Next(0, 50);
}

foreach (var item in randomInputsArray)
{
    Console.WriteLine(item);
}

FindMinMaxValue(randomInputsArray);

static (int min, int max) FindMinMaxValue(int[] input)
{
    int min = 50;
    int max = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] >= max)
        {
            max=input[i];
        }
        if (input[i] < min)
        {
            min = input[i];
        }

    }

    Console.WriteLine($"Minimal value: {min}");
    Console.WriteLine($"Maximal value: {max}");


    return (min, max);
}