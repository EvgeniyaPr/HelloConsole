Console.Clear();
// Console.SetCursorPosition(10, 4);
// System.Console.WriteLine("+");

int xa = 35; 
int ya = 1;
int xb = 1;
int yb = 15;
int xc = 70;
int yc = 15;

Console.SetCursorPosition(xa, ya);
System.Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
System.Console.WriteLine("+");

int x = xa, y = xb;

int count = 10;

while (count < 1000)
{
    int what = new Random().Next(0, 3); // [0;3) 0,1,2
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if (what ==1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if (what ==2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition (x, y);
    Console.WriteLine("+");
    count = count + 1; // coount +=1; count ++;

}

Console.SetCursorPosition(xc, yc);
System.Console.WriteLine("+");