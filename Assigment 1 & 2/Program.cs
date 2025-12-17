// Assigment #1 :-
// اكتب برنامج يطلب من المستخدم ادخال بياناته
// اسمه
// عمره 
// راتب الشهري
// عدد ساعات العمل  اليومية

// احسب الراتب السنوي
// احسب عدد ساعات العمل الشهرية
// احسب عدد ساعات العمل السنوي
// متسوط الدخل اليومي
// العمر بعد اربع سنوات



// الواجب الأول   
Console.WriteLine("----------Assignment 1----------");

Console.WriteLine("Enter your name :");
string name = Console.ReadLine();

Console.WriteLine("Enter your Age :");
short age = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter your monthly salary :");
short monthSalary = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter your work hours :");
short workHours = Convert.ToInt16(Console.ReadLine());

int annualSalary = monthSalary * 12;
Console.WriteLine($"your Annual Sallary is : {annualSalary}");

// short onthlyHours = workHours * 30; ما زبطت
int monthlyHours = workHours * 30;
Console.WriteLine($"Your monthly work hours is : {monthlyHours} hours.");

int annualHours = monthlyHours * 12;
Console.WriteLine($"Your Annual Work Hours is : {annualHours} hours.");

int avarage = (monthSalary / 30) / 2;
Console.WriteLine($"Your avarge Daily income is : {avarage}JD");

int ageAfter4yrs = age + 4;
Console.WriteLine($"Your Age after 4 years is : {ageAfter4yrs} years");


// Assignment 2
Console.WriteLine("----------Assignment 2----------");

Console.WriteLine("Enter the price of product :");
double price = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of purchased pieces : ");
short pieces = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Are you VIP or Regular costumer ?");
string typeOfCostumer = Console.ReadLine();
typeOfCostumer = typeOfCostumer.ToLower();

double totalPrice;

if (typeOfCostumer == "vip")
{
    price *= 0.8;
    totalPrice = price * pieces;
    Console.WriteLine($"The number of purchased pieces are {pieces} and the Total price is : {totalPrice}JD ");

}
else if (typeOfCostumer == "regular")
{
    if (pieces >= 5)
    {
        price *= 0.9;
        totalPrice = price * pieces;
        Console.WriteLine($"The number of purchased pieces are {pieces} and the Total price is : {totalPrice}JD ");
    }
    else if (pieces < 5 && pieces > 0)
    {
        totalPrice = price * pieces;
        Console.WriteLine($"The number of purchased pieces are {pieces} and the Total price is : {totalPrice}JD ");

    }
    else
    {
        Console.WriteLine("Please Enter a Valid number of pieces ");
    }
}
else
{
    Console.WriteLine("The Type you entered is Invailed pleas Enter 'VIP' or 'Regular' !");
}
