namespace CPPPPAdvancedProgramming2;
using System;
class Program
{
    static void Main(string[] args) //Tutorial's link: https://www.youtube.com/watch?v=L09paGvd5RE&list=PLQVXoXFVVtp0h5_5vM5ssqVdROQj5k_3p&index=2
    {
        //Jagged Array Revision
        /*int[][][][] arr1 = new int[3][][][];
        arr1[0] = new int[2][][]; 
        arr1[1] = new int[2][][]; //Initial dimension
        arr1[2] = new int[2][][]; 
        
        arr1[0][0] = new int[2][]; 
        arr1[0][1] = new int[2][]; 
        arr1[1][0] = new int[2][]; //Second Dimension
        arr1[1][1] = new int[2][]; 
        arr1[2][0] = new int[2][];
        arr1[2][1] = new int[2][];
        
        arr1[0][0][0] = new int[2] {1, 2};
        arr1[0][0][1] = new int[2] {3, 4};
        arr1[0][1][0] = new int[2] {5, 6};
        arr1[0][1][1] = new int[2] {7, 8};
        arr1[1][0][0] = new int[2] {9, 10};
        arr1[1][0][1] = new int[2] {11, 12}; //Third Dimension
        arr1[1][1][0] = new int[2] {13, 14};
        arr1[1][1][1] = new int[2] {15, 16};
        arr1[2][0][0] = new int[2] {17, 18};
        arr1[2][0][1] = new int[2] {19, 20};
        arr1[2][1][0] = new int[2] {21, 22};
        arr1[2][1][1] = new int[2] {23, 24};

        foreach (var firstDimension in arr1) 
            foreach (var secondDimension in firstDimension)
                foreach (var thirdDimension in secondDimension)
                    foreach (var index in thirdDimension)
                        Console.WriteLine(index);
        
        //or

        int[][][] arr2 = new int[2][][]
        {
            new int[2][] {new int[2] {1,2}, new int[2] {3,4}}, new int[2][] {new int[2] {5,6}, new int[2] {7,8}},
        };

        foreach (var firstDimension in arr2)
            foreach(var secondDimension in firstDimension)
                foreach (var index in secondDimension)
                    Console.WriteLine(index);*/
        

        //3-Dimensional Array Pattern
        /*int[,,] arr1 = new int[2,2,3]
        {
            {
                {1,2,3},{4,5,6}
            },
            {
                {7,8,9},{10,11,12}
            }
        };

        foreach (var index in arr1)
        {
            Console.WriteLine(index);
        }*/
        
        
        //typeof() Method Review
        /*Console.WriteLine(typeof(PersonalStruct));
        Console.WriteLine(typeof(int)); //Provides The Struct Name and Over The Name Space It Was Declared Under */
        
        
        //Defining arrays with CreateInstance method
        /*int[] _intArr1 = (int[])Array.CreateInstance(typeof(int),5);
        int[,] _intArr2D1 = (int[,])Array.CreateInstance(typeof(int),5,5);
        int[,,] _intArr3D1 = (int[,,])Array.CreateInstance(typeof(int),5,5,5);*/
        
        
        //Tupple Array Syntax 
        /*(int tuppleNo, string tuppleStr)[] _tuppleArr = new (int tuppleNo, string tuppleStr)[2] {(1,"One"),(2,"Two")}; //Using parentheses while typing the elements of tupple arrays.
        Console.WriteLine($"Here is the initial element of our tuple array: {_tuppleArr[0]}");*/
        
        //Multidimensional Tupple Array Syntax
        /*(int multiDTuppleNo, string multiDTuppleStr)[,] _multiDTuppleArr = new (int multiDTuppleNo, string multiDTuppleStr)[2,2]
        {
            {(1,"One"),(2,"Two")},
            {(3, "Three"),(4,"Four")}
        };

        foreach (var tupleElement in _multiDTuppleArr)
        {
            Console.WriteLine(tupleElement);
        }*/
    }
}
struct PersonalStruct{}