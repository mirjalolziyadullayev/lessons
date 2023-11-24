/*
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

*/
