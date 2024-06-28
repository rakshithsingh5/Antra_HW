namespace Assignment3;

public class Color
{
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

        public int Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }

        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }
        }

        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value;
            }
        }

        public int Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }

        // Method to get the grayscale value
        public double GetGrayscale()
        {
            return (red + green + blue) / 3.0;
        }
}