using System.Globalization;

int[] array1 = new int[] {1, 2, 3, 4, 5};
int[] array2 = new int[] {1, 2, 6, 7, 8};
var result=ArrayAdding(array1, array2);
foreach (int i in result)
{
    Console.WriteLine(i);
    
}

static int[] ArrayAdding(int[] input1, int[] input2)
{
    int j = 0;
    List<int> result = new List<int>();
    for (int i = 0; i < input1.Length; i++)
    {
        
        if (input1[i] == input2[i])
        {
            result.Add(input1[i]);
            //result[j] = input1[i];
            //j++;
        }
        else
        {
            result.Add(input1[i]);
            result.Add(input2[i]);
            //result[j] = input1[i];
            //result[j+1]=input2[i];
            //j += 2;
        }
    }

    for (int i = 0; i < result.Count; i++)
    {
        if (result[i]==0)
        {
            result.Remove(i);
        }
    }

    
    
  
    return result.ToArray();
}