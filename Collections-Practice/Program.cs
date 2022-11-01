//Three Basic Arrays
//1 Create array with numbers 0 to 10
int X = 10;
int[] arr = Enumerable.Range(0, X+1).ToArray();

// foreach(var num in arr){
//     Console.WriteLine(num);
// }

//2 Create array with three names
string[] arr2;
arr2 = new string[] {"Tim", "Martin", "Nikki", "Sara"};

for (int i = 0; i < arr2.Length; i++)
{
    // Console.WriteLine($"Name {i+1}: {arr2[i]}");
}

//3 Create an array of length 10 that alternates between true and false values, starting with true
bool[] arr3 = new bool[10];
for (int i = 0; i<arr3.Length; i++){
    if(i%2 == 0){
        arr3[i] = true;
    }
    else {
        arr3[i] = false;
    }
    // Console.WriteLine(arr3[i]);
}

//List of Flavors
List<string> list = new List<string> {"Strawberry", "Vanilla", "Chocolate", "Mint", "Coffee"};
// Console.WriteLine($"There are {list.Count} Flavors");

//Remove third flavor and output new list length
list.RemoveAt(2);
// Console.WriteLine($"There are {list.Count} Flavors");

//User Info Dictionary
// Add People and Flavors from array and list to dictionary
Dictionary<string,string> dict = new Dictionary<string,string>();
for (int i = 0; i<arr2.Length; i++){
    dict.Add(arr2[i], list[i]);
}

foreach(var person in dict){
    Console.WriteLine(person);
}