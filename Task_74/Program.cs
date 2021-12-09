// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, 
//которые можно построить из букв этого алфавита.
int n =0;
void FindWorlds(string alp, char[] word, int length = 0)
{
    if (length== word.Length)
    {
         Console.WriteLine($"{n++} {new String(word)}"); return;
    }
for (int i = 0; i < alp.Length; i++)
{
    word[length] = alp[i];
    FindWorlds(alp,word,length+1);
}
}
FindWorlds("аисв",new char[4]);