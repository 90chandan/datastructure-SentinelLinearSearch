// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Sentinel Linear Search algoright");

//array of elements
int[] arr  = {10,50,30,70,80,60,20,90,40};

//target element
int searchElement = 100;

int indexWithSentinelSearch = Search.SentinelLinearSearh(arr,searchElement);

if(indexWithSentinelSearch != -1)
    Console.WriteLine($"Index/Postion of element {searchElement} in given array is with SentinelSearch : {indexWithSentinelSearch}");
else
    Console.WriteLine($"Element {searchElement} is not present in given array");


//target element
int searchElement2 = 20;

int indexWithSentinelSearch2 = Search.SentinelLinearSearh(arr,searchElement2);

if(indexWithSentinelSearch2 != -1)
    Console.WriteLine($"Index/Postion of element {searchElement2} in given array is with SentinelSearch : {indexWithSentinelSearch2}");
else
    Console.WriteLine($"Element {searchElement2} is not present in given array");

public class Search{
    //sentinel linear search
    public static int SentinelLinearSearh(int[] arr, int x){
        int len = arr.Length;

        int last = arr[len -1];

        arr[len-1] = x;

        int index = 0 ;

        while(arr[index] != x)
            index++;

        arr[len-1] = last;

        if((index < len-1) || (arr[len-1] == x))
            return index;
        return -1;
        
    }
}