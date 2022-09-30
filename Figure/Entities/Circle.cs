using Figure.Entities.Enums;

namespace Figure.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
       
        
        public Circle()
        {            
        }
        public Circle(Color color, double radius)
        :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius ,2)* Math.PI;
        }
    }
}