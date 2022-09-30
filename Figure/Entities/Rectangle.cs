using Figure.Entities.Enums;
using Figure.Entities;
namespace Figure.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public Rectangle()
        {            
        }
        public Rectangle(Color color, double width, double height)
        : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area(){
            return Width * Height;
        } 
        
    }
}