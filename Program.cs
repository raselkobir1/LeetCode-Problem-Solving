// See https://aka.ms/new-console-template for more information
using LeetCodeProblem.Solutions;

//Two sum
//int[] input = { 2, 7, 11, 15 };
//int target = 9;
//TwoSumSulotion twoSumSulotion = new TwoSumSulotion();
//twoSumSulotion.TwoSum(input, target);

//int input = 121;
//PalindromeCheck palindromeCheck = new PalindromeCheck();
//var result = palindromeCheck.IsPalindrome(input);
//Console.WriteLine(result);

//var Input = "Let's take LeetCode contest";
//ReverseWordsProblem reverseWordsProblem = new ReverseWordsProblem();
//var result = reverseWordsProblem.ReverseWords(Input); 
//Console.WriteLine(result);

//int input = -1236;
//ReverseInteger_mid reverse = new();
//var result = reverse.Reverse(input);
//Console.WriteLine(result);

//int[] nums = { 1,3, 3, 4, 2 };
//_287_FindDuplicateFromIntArray findDuplicate = new _287_FindDuplicateFromIntArray();
//var result = findDuplicate.FindDuplicate(nums);
//Console.WriteLine(result); 

//string haystack = "sadbutsad", needle = "dbu";
//_28_FindTheIndexOfFirstOccurenceOf2Strings index = new();
//var result = index.StrStr(haystack, needle);
//Console.WriteLine(result); 

//int divident = 0;
//int divisor = 1;

//_29_DivideTwoInteger divideTwoNum = new _29_DivideTwoInteger(); 
//var result = divideTwoNum.Divide(divident, divisor);
//Console.WriteLine(result); 

int[] arr = { 5, 7 ,9,12,15};
int target = 6;
FindValueWithBinarySearch search = new FindValueWithBinarySearch();
var result = search.BinarySearch(arr,target);
Console.WriteLine(result);  


Console.WriteLine();
