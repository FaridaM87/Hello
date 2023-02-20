Console.WriteLine(" Введите количество элементов массива и сам элемент массива: ");
int size  = int.Parse(Console.ReadLine());

string[] Array1 = new string[size];

for (int i = 0; i < size; i++)
{
	string res = Console.ReadLine();
	Array1[i] = res;  
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", Array1));
Console.Write("]");

int count = 0;
int Symbols = 3;

for (int i = 0; i < Array1.Length; i++){
	if(Array1[i].Length <= Symbols){
		count++;
	}   
}
Console.WriteLine();
Console.Write("Полученный массив: [");
string[] Array2 = new string[count];
int j = 0;
for (int i = 0; i < Array1.Length; i++){
    if(Array1[i].Length <= Symbols){
        Array2[j] = Array1[i];
        Console.Write(Array2[j] + ",]");
        j++;
    }
}


