﻿// See https://aka.ms/new-console-template for more information
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

int[] nums = { 1,3, 3, 4, 2 };
_287_FindDuplicateFromIntArray findDuplicate = new _287_FindDuplicateFromIntArray();
var result = findDuplicate.FindDuplicate(nums);
Console.WriteLine(result); 
Console.WriteLine();
