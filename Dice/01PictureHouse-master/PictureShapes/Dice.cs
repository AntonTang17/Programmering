using System;

namespace PictureShapes
{
    class Dice
    {

        private static Random numberGenerator;
        private Circle dot0 = new Circle();
        private Circle dot1 = new Circle();
        private Circle dot2 = new Circle();
        private Circle dot3 = new Circle();
        private Circle dot4 = new Circle();
        private Circle dot5 = new Circle();
        private Circle dot6 = new Circle();



        public Dice()
        {
            numberGenerator = new Random();
            DrawImage();
            Roll();

        }

        public void Roll()
        {
            int number = numberGenerator.Next(1, 7);

            if (number%2 == 1)
            {
                dot0.MakeVisible();
            }

            if (number >= 2)
            {
                dot1.MakeVisible();
                dot2.MakeVisible();
            }

            if (number >= 4)
            {
                dot3.MakeVisible();
                dot4.MakeVisible();
            }

            if (number == 6)
            {
                dot5.MakeVisible();
                dot6.MakeVisible();
            }
        }
        public void DrawImage()
        {
                     
            
            dot0.MakeInVisible();
            dot0.ChangeColor("red");
            dot0.ChangeSize(100);
            dot0.MoveHorizontal(250);
            dot0.MoveVertical(150);

           
            dot1.MakeInVisible();
            dot1.ChangeColor("red");
            dot1.ChangeSize(100);
            dot1.MoveHorizontal(100);
            dot1.MoveVertical(0);

            
            dot2.MakeInVisible();
            dot2.ChangeColor("red");
            dot2.ChangeSize(100);
            dot2.MoveHorizontal(400);
            dot2.MoveVertical(300);

           
            dot3.MakeInVisible();
            dot3.ChangeColor("red");
            dot3.ChangeSize(100);
            dot3.MoveHorizontal(100);
            dot3.MoveVertical(300);

           
            dot4.MakeInVisible();
            dot4.ChangeColor("red");
            dot4.ChangeSize(100);
            dot4.MoveHorizontal(400);
            dot4.MoveVertical(0);

            
            dot5.MakeInVisible();
            dot5.ChangeColor("red");
            dot5.ChangeSize(100);
            dot5.MoveHorizontal(400);
            dot5.MoveVertical(150);

            
            dot6.MakeInVisible();
            dot6.ChangeColor("red");
            dot6.ChangeSize(100);
            dot6.MoveHorizontal(100);
            dot6.MoveVertical(150);

        }
        
    }
}
