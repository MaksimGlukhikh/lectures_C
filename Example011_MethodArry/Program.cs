int [] array = {21,24,38,44,25,96,17,38,29};
int n = array.Length;
int find = 44;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}