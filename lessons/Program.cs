﻿/*
 * 
 *********************** 1 task
 * 
int number1 = 2;
int number2 = 2;


if (number1 == number2)
{

    Console.WriteLine($"{number1} and {number2} is equal");
} else
{
    Console.WriteLine("they are not equal");
}



************************ 2 task


int number = 2;

if (number%2 == 0)
{
    Console.WriteLine("even");
} else
{
    Console.WriteLine("odd");
}



************************ 3 task


int number = -1;

if (number>0)
{
    Console.WriteLine("number is positive");
} else if  (number==0)
{
    Console.WriteLine("number is not positive or negative");
} else
{
    Console.WriteLine("number is negative");
}





************************** 4 task



int year = 2016;

if (year%4==0)
{
    if (year%100 == 0)
    {
        if (year%400 == 0)
        {
            Console.WriteLine("leap year");
        }
        else
        {
            Console.WriteLine("not leap year");
        }
    } else
    {
        Console.WriteLine("leap year");

    }
} else
{
    Console.WriteLine("not leap year");
}




************************** 5 task



int candidate = 21;
int vote = 18;

if (candidate >= 18)
{
    Console.WriteLine("you're eligible for casting your vote");
} else
{
    Console.WriteLine("you're not eligible for casting your vote");

}






//********************** 6 task




Console.WriteLine("3 ta butun sondan eng kattasini topish xizmati. lol");
int a, b, c;

Console.WriteLine("A sonni kiriting:"); 
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B sonni kiriting:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("C sonni kiriting:");
c = Convert.ToInt32(Console.ReadLine());



if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("A katta");
    } else { 
        Console.WriteLine("C katta");
    }
} else
{
    if (b > c)
    {
        Console.WriteLine("B katta");
    } else
    {
        Console.WriteLine("C katta");
    }
}


************** or


if (a>b && a>c)
{
    Console.WriteLine("A");
} else if (b > a && b > c)
{
    Console.WriteLine("B");
} else
{
    Console.WriteLine("C");
}




//****************** 7 task

int grade = 90;

if  (grade == 90)
{
    Console.WriteLine("A");
} else if (grade >= 70 ||  grade <=90)
{
    Console.WriteLine("B");
} else if (grade >=50 || grade <=70)
{
    Console.WriteLine("C");
} else if (grade<50)
{
    Console.WriteLine("F");
}




**************************** 8 task


int a = 1, b  = 2;

bool result = false;
if (a % 2 == 0 && b % 2 == 0)
{
    result = true;
}
Console.WriteLine(result);




**************************** 9 task


int person = 165;

if (person >= 165)
{
    Console.WriteLine("tall");
} else
{
    if (person >= 150)
    {
        Console.WriteLine("averege height");
    } else if (person < 150) {
        Console.WriteLine("dwarf");
    }
}



****************************** 10 task



int a =10, b = 5, c =3;

if (a > b && a > c)
{
    Console.WriteLine(a);
} else if (b > a && b > c)
{
    Console.WriteLine(b);
} else
{
    Console.WriteLine(c);
}




******************************* 11 task



int x = Convert.ToInt32(Console.ReadLine()), y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("first quadrant");
} else if (x < 0 && y > 0)
{s
    Console.WriteLine("second quadrant");
} else if (x < 0 && y < 0)
{
    Console.WriteLine("third quadrant");
} else if (x > 0 && y < 0)
{
    Console.WriteLine("fourth quadrant");
} else if (x == 0 && y == 0)
{
    Console.WriteLine("origin");
} else if (x == 0 && y != 0)
{
    Console.WriteLine("y-axis");
} else if (x != 0 && y == 0)
{
    Console.WriteLine("x-axis");
} else
{
    Console.WriteLine("invalid input");
}





**************************** 12 task


int math = 65;
int phy = 60;
int chem = 60;

int total = 0;

if (math >= 65)
{
    total += math;
} 
if (phy >= 55)
{
    total += phy;
}
if (chem >= 50)
{
    total += chem;
}

    if (total >= 180)
{
    Console.WriteLine($"totally is {total}. Congrats! You passed.");
} else
{
    Console.WriteLine("Your balls not enough it should be greater or equal to 180");
}





****************************** 13 task


int celsius = -15;
int fahrenheit;

fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine(fahrenheit);






**************************** 14 task


int a,b;
Console.WriteLine("Welcome!");
Console.WriteLine("Enter number for A:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number for B:");
b = Convert.ToInt32(Console.ReadLine());

int chose;

Console.WriteLine("select what you need:");
Console.WriteLine("(1) for addition");
Console.WriteLine("(2) for subtraction");
Console.WriteLine("(3) for multiplication");
Console.WriteLine("(4) for devision");

chose = Convert.ToInt32(Console.ReadLine());

if (chose == 1)
{
    Console.WriteLine($"\n{a} + {b} = {a + b}");
} else if (chose == 2)
{
    Console.WriteLine($"\n{a} - {b} = {a - b}");
} else if (chose == 3)
{
    Console.WriteLine($"\n{a} * {b} = {a * b}");
} else if (chose == 4)
{
    Console.WriteLine($"\n{a} / {b} = {a / b}");
} else
{
    Console.WriteLine("invalid input");
}




*************************** 15 task




string character = "a";

string vowel = "aouie";
string consonant = "bcdfghjklmnpqrstvwxyz";

for (int i = 0; i < vowel.Length; i++)
{
    if (character.Contains(vowel[i]))
    {
        Console.WriteLine($"charcacter is vowel");
    }
}
for (int i = 0; i < consonant.Length; i++)
{
    if (character.Contains(consonant[i])) { 
        Console.WriteLine($"charcacter is consonant");
    }
}

*/

using System.ComponentModel.DataAnnotations;

int A = 0, B = 0;


int[] number = new int [] {0,1,2,3,4,5,6,7,8,9,10};
int[] used = new int[] {};

var found = true;
var notUsed = false;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter for A");
    A = Convert.ToInt32(Console.ReadLine());

    for (int j = 0; j < number.Length; j++)
    {
        if (A == number[j])
        {
            for (int k = 0; k < used.Length; k++)
            {
                if (A != 0) 
                {

                    if (A != used[k])
                    {
                        used = used.Append(A).ToArray();
                        number[j] = 0;
                        notUsed = true;
                        break;
                    } else
                    {
                        Console.WriteLine($"A's value is used {used[i]}");
                    }
                }
            }
            if (!notUsed)
            {
                Console.WriteLine("Already used");
            }
            found = true; 
            break;
        }
    } 
    if (!found)
    {
        Console.WriteLine("not found");
    }
    Console.WriteLine("[{0}]", string.Join(", ", number));
    Console.WriteLine("[{0}]", string.Join(", ", used));
}

