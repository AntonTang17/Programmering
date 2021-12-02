using System;

namespace PictureShapes
{
    class Dice
    {
        Circle[] dots;
           

        private static Random numberGenerator;
        



        public Dice()
        {
            dots = new Circle[7];
            dots[0] = new Circle();
            dots[1] = new Circle();
            dots[2] = new Circle();
            dots[3] = new Circle();
            dots[4] = new Circle();
            dots[5] = new Circle();
            dots[6] = new Circle();

        numberGenerator = new Random();
            DrawImage();
            Roll();

        }

        public void Roll()
        {
            int number = numberGenerator.Next(1, 7);

            if (number%2 == 1)
            {
                dots[0].MakeVisible();
            }

            if (number >= 2)
            {
                dots[1].MakeVisible();
                dots[2].MakeVisible();
            }

            if (number >= 4)
            {
                dots[3].MakeVisible();
                dots[4].MakeVisible();
            }

            if (number == 6)
            {
                dots[5].MakeVisible();
                dots[6].MakeVisible();
            }
        }
        public void DrawImage()
        {
                     
            
            dots[0].MakeInVisible();
            dots[0].ChangeColor("red");
            dots[0].ChangeSize(100);
            dots[0].MoveHorizontal(250);
            dots[0].MoveVertical(150);

           
            dots[1].MakeInVisible();
            dots[1].ChangeColor("red");
            dots[1].ChangeSize(100);
            dots[1].MoveHorizontal(100);
            dots[1].MoveVertical(0);

            
            dots[2].MakeInVisible();
            dots[2].ChangeColor("red");
            dots[2].ChangeSize(100);
            dots[2].MoveHorizontal(400);
            dots[2].MoveVertical(300);

           
            dots[3].MakeInVisible();
            dots[3].ChangeColor("red");
            dots[3].ChangeSize(100);
            dots[3].MoveHorizontal(100);
            dots[3].MoveVertical(300);

           
            dots[4].MakeInVisible();
            dots[4].ChangeColor("red");
            dots[4].ChangeSize(100);
            dots[4].MoveHorizontal(400);
            dots[4].MoveVertical(0);

            
            dots[5].MakeInVisible();
            dots[5].ChangeColor("red");
            dots[5].ChangeSize(100);
            dots[5].MoveHorizontal(400);
            dots[5].MoveVertical(150);

            
            dots[6].MakeInVisible();
            dots[6].ChangeColor("red");
            dots[6].ChangeSize(100);
            dots[6].MoveHorizontal(100);
            dots[6].MoveVertical(150);

        }
        
    }
}
