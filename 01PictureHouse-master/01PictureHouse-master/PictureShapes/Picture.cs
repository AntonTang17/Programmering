namespace PictureShapes
{
    class Picture
    {

        public Picture()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            Square wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("red");
            wall.ChangeSize(200);
            wall.MoveHorizontal(70);
            wall.MoveVertical(20);

            Square window = new Square();
            window.MakeVisible();
            window.ChangeColor("black");
            window.ChangeSize(70);
            window.MoveHorizontal(100);
            window.MoveVertical(60);

            Triangle roof = new Triangle();
            roof.MakeVisible();
            roof.ChangeColor("black");
            roof.ChangeSize(300);
            roof.MoveHorizontal(-27);
            roof.MoveVertical(-8);

            Circle sun = new Circle();
            sun.MakeVisible();
            sun.ChangeColor("yellow");
            sun.ChangeSize(100);
            sun.MoveHorizontal(500);
            sun.MoveVertical(-20);

        }
    }
}
