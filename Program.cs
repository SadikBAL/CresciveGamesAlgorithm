// See https://aka.ms/new-console-template for more information
using CresciveGamesAlgorithm;

Console.WriteLine("Hello, Crescive Games <3 \n");

Knot Yellow = new Knot("Yellow");
Knot Blue = new Knot("Blue");
Knot Red = new Knot("Red");
Knot Pink = new Knot("Pink");
Knot Purple = new Knot("Purple");
Knot Orange = new Knot("Orange");

Yellow.AddKnot(Blue);
Yellow.AddKnot(Red);
Blue.AddKnot(Yellow);
Red.AddKnot(Yellow);
Red.AddKnot(Pink);
Pink.AddKnot(Red);
Purple.AddKnot(Orange);
Orange.AddKnot(Purple);

Yellow.PrintGroup();
Purple.PrintGroup();
Blue.PrintGroup();