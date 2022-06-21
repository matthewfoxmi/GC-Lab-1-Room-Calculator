Console.WriteLine("What is the length of the classroom in feet?");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("What is the width of the classroom in feet?");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("What is the height of the classroom in feet?");
double height = double.Parse(Console.ReadLine());


double perimeter = 2 * (length + width);
double area = length * width;
double volume = length * width * height;
double surfacearea = 2 * (length * width) + 2 * (width * height) + 2 * (length * height);

Console.WriteLine("The classroom's perimeter is: " + perimeter + " feet.\n" +
                  "The classroom's area is: " + area + " feet squared.\n" +
                  "The classroom's volume is: " + volume + " cubic feet. \n" +
                  "The classroom's surface area is: " + surfacearea + " feet squared\n ");
                   
if (area < 250)
   {
    Console.WriteLine("This room is pretty small!\n");
   }
else if (area >= 250 && area < 650)
   {
    Console.WriteLine("This is a medium sized room\n");
   }
else if (area >= 650)
    {
    Console.WriteLine("This is a pretty large room!\n");
    }

Console.WriteLine("Thanks for using this Classroom Detail Generator!");

