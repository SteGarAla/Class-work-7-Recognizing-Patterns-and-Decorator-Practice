
namespace ClassWork7
{
   //widget interface
    interface Widget
    {
        //Widget only has one operation that all other classes that extend it must implement
        public void Draw();
    }

    //class TextField extends the Widget interface
    class TextField : Widget
    {
        private int width;
        private int height;

        //parameterized constructor that takes in two integer w & h
        public TextField(int w, int h)
        {
            width = w; height = h;
        }
        
        //since Textfield extends Widget we must use the Draw() operation!
        public void Draw()
        {
            //prints the width and height that are passed in the parameterized constructor
            Console.WriteLine($"TextField: {width}, {height}");
        }
    }

    //abstract decorator class implements the Widget interface
    abstract class Decorator : Widget
    {
        //Decorator has one attribute a Widget object (containment relationship)
        private Widget wid;

        //parameterized constructor that takes in that Widget object and sets it equal to the class attribute (wid)
        public Decorator(Widget wid)
        {
            this.wid = wid;
        }

        //The draw function is made virtual so that child classes can override it to fit their need
        public virtual void Draw()
        {
            wid.Draw();
        }
    }


    //BorderDecoratorClass is the child class of Abstract Decorator Class
    //This would be considered a concrete class
    class BorderDecorator : Decorator
    {
        //Im not sure if this was the right thing to do but it was the only way i was able to remove the error
        public BorderDecorator(Widget w) : base(w)
        {
            //calls our Draw() method and then the base class Draw() method
            Draw();
            base.Draw();
        }

        //overriding the base Draw class so that we can let the user know we are using the BorderDecorator on the TextField class
        public override void Draw()
        {
            Console.WriteLine("I am the BorderDecorator, holding a");
        }

    }

    //Concrete ScrollDecorator is the child class of the Abstract Decorator Class
    class ScrollDecorator : Decorator
    {
        //We are also using the Base classes constructor in order to use the base.Draw() method
        public ScrollDecorator(Widget w) : base(w)
        {
            Draw();
            base.Draw();
        }

        //overriding the base Draw class so that we can let the user know we are using the ScrollDecorator on the TextField class
        public override void Draw()
        {

            Console.WriteLine("I am the ScrollDecorator, holding a ");
        }
    }

    //Concrete ScrollDecorator is the child class of the Abstract Decorator Class
    class RandomDecorator : Decorator
    {
        //We are also using the Base classes constructor in order to use the base.Draw() method
        public RandomDecorator(Widget w) : base(w)
        {
            Draw();
            base.Draw();
        }

        //overriding the base Draw class so that we can let the user know we are using the ScrollDecorator on the TextField class
        public override void Draw()
        {

            Console.WriteLine("I am the RandomDecorator, holding a ");
        }
    }

    class DecoratorDemo
    {
        static void Main()
        {
            //our TextField obj passing in our info that will be also used in our decorators
            TextField obj = new TextField(15345345, 234324530);


            //decorating the obj with BorderDecorator and ScrollDecorator + additonal RandomDecorator
            BorderDecorator decorator = new BorderDecorator(obj);
            Console.WriteLine('\n');

            ScrollDecorator scroll = new ScrollDecorator(obj);
            Console.WriteLine('\n');

            RandomDecorator random = new RandomDecorator(obj);
        }
    }










}