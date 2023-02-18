namespace ClassWork7
{
   

    //pass
    interface Widget
    {
        public void draw();
    }

    //pass
    class TextField : Widget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            width = w; height = h;
        }
        public void draw()
        {
            Console.WriteLine($"TextField: {width}, {height}");
        }
    }

    //pass
    abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget wid)
        {
            this.wid = wid;
        }

        public void draw()
        {
            wid.draw();
        }
    }



    class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w)
        {
            //something
        }

        override void draw()
        {
            base.draw();
            Console.WriteLine("I am the BorderDecorator!");
        }

    }

    class ScrollDecorator : Decorator
    {
        ScrollDecorator(Widget w)
        {
            //something
        }

        public void draw()
        {
            base.draw();
            Console.WriteLine("I am the ScrollDecorator!");
        }



        class DecoratorDemo
        {
            static void Main()
            {
                TextField obj = new ScrollDecorator(); 
            }
        }

    }








}