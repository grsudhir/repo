using System.IO;
using System;

class Program
{   char [] word= new char[4];
   char [] word1= new char[4];static int n=0;
    public void fun(char c)
    {int i;
      for(i=0;i<4;i++)
        {     if(c==word[i] && c!=word1[i])
                {word1[i]=c;n++;break;}
        }
    }
        
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Program program=new Program();
        
         
        program.word[0]='g';
        program.word[1]='o';
        program.word[2]='a';
        program.word[3]='t';
        program.word1[0]='*';
        program.word1[1]='*';
        program.word1[2]='*';
        program.word1[3]='*';
        while(n!=4){
        char c= Convert.ToChar(Console.ReadLine());
        program.fun(c);
        Console.WriteLine(program.word1);
        }
        
        
         
        
    }
}
