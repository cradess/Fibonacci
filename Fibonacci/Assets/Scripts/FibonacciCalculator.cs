using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FibonacciCalculator : MonoBehaviour
{
    private ulong[] fibonacciNumbers;
    

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            FibAddition();
    }

    /// <summary>
    /// Returns the Nth Fibonacci term.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public void FibAddition(int n = 200)
    {
        fibonacciNumbers = new ulong[n];

        for (int i = 0; i < n; i++)
        {
            switch (i)
            {
                case 0:
                case 1:
                    fibonacciNumbers[i] = (ulong)i;
                    break;
                default:
                    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                    break;
            }
            Debug.Log(fibonacciNumbers[i]);
        }
    }

    /// <summary>
    /// If given two terms, will return fibonacci numbers from them. Does not check validity. May be used to iterate on given numbers with an unknown N
    /// </summary>
    public int fibIterator(int a = 0, int b = 1)
    {
        return (a + b);
    }
}
