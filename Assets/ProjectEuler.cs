using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectEuler : MonoBehaviour
{
    public long number;
    public List<long> factors = new List<long>();

    void Start()
    {
        Excercise4();
    }
    void Update()
    {
        Excercise3(number);
    }
    //add all the numbers from 0 to limit divisible by any of the multiples
    void Excercise1(int limit, int[] multiples)
    {
        int sum = 0;
        for(int i=0; i<limit; i++)
        {
            for(int j = 0; j<multiples.Length; j++)
            {
                if(i%multiples[j] == 0)
                {
                    sum+=i;
                    break;
                }
            }
        }
        Debug.Log(sum);
    }
    //sum all fibonacci even numbers smaller than 4,000,000
    void Excercise2()
    {
        int currentNum;
        int firstNum = 1;
        int secondNum = 2;
        int sum = 2;
        while(secondNum<4000000)
        {
            currentNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = currentNum;
            if(currentNum%2 == 0)
            {
                sum+= currentNum;
            }
        }
        Debug.Log(sum);
    }
    //get the largest prime 
    void Excercise3(long num)
    {
        factors = new List<long>();
        for(long i = 2; i<num; i++)
        {
            while(num%i == 0)
            {
                factors.Add(i);
                num /= i;
            }
        }
        if(num!=1)
        factors.Add(num);
    }
    //get the biggest palindrome of a 3digit x 3digit result.
    void Excercise4()
    {
        int biggestPalindrome = 0;;
        for(int i = 100; i<1000; i++)
        {
            for(int j = 100; j<1000; j++)
            {
                int result = i*j;
                string numString = (i*j).ToString();
                int digitSize = numString.Length;
                //filters
                for(int index = 0; index<(digitSize+1)/2 ; index++)
                {
                    int maxIndex = ((digitSize+1)/2)-1;
                    if(numString[index] == numString[digitSize-1-index])
                    {
                        if(index == maxIndex)
                        {
                            if(biggestPalindrome<result)
                            {
                                biggestPalindrome = result;
                            }
                            break;
                        }
                    }
                    else{
                        break;
                    }
                }
            }
        }
        Debug.Log(biggestPalindrome);
    }
}
