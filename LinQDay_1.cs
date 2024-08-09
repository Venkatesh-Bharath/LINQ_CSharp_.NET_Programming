using System;
using System.Collections.Generic;
using System.Linq;

public class LinQDay_1{
  
    public static void Main(String[] args)
    {
     List<int> list=new List<int>{1,2,3,4,5,6,7,8,9};
    // List<int> ans=new List<int>();
     
    // foreach(int e in list){
    //   if(e%2!=0){
    //     ans.Add(e);
    //   }
       
    // }
    
    List<int> ans=list.Where(e=>e%2!=0).ToList();
    Console.WriteLine(string.Join(" ",ans));
    
    
    int a=10;
    int b=30;
    // max of 2 number
    int max=new []{a,b}.Max();
    Console.WriteLine(max);
    // min of 2 number
    int min=new []{a,b}.Min();
    Console.WriteLine(min);
    int c=45;
    // max of 3 number
    int max1=new []{a,b,c}.Max();
    Console.WriteLine(max1);

    }

}


