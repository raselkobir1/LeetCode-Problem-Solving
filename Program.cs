// See https://aka.ms/new-console-template for more information
using LeetCodeProblem.Solutions;

//Two sum
//int[] input = { 2, 7, 11, 15 };
//int target = 9;
//TwoSumSulotion twoSumSulotion = new TwoSumSulotion();
//twoSumSulotion.TwoSum(input, target);

int input = -121;
PalindromeCheck palindromeCheck = new PalindromeCheck();
var result = palindromeCheck.IsPalindrome(input);
Console.WriteLine(result);
Console.WriteLine();
