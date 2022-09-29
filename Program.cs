int NewArrLength(String[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)

        if (str[i].Length <= 3)
            count++;

    return count;
}

void To3CharString(int arrLength, String[] str)
{
    String[] newArr = new String[arrLength];
    for (int i = 0; i < newArr.Length; i++)

        for (int j = 0; j < str.Length; j++)

            if (str[j].Length <= 3 && str[j] != "0")
            {
                newArr[i] = str[j];
                str[j] = "0";
                Console.Write(newArr[i] + ", ");
            }
}

string[] arr = { "Hello", "2", "world", ":-)", "No", "Gsdfj", "dfe" };
int arrLength = NewArrLength(arr);
To3CharString(arrLength, arr);


