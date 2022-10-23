namespace Cube2d.Models
{
    public class Graphics
    {
        //ширина консоли
        public int width { get; }
        //Высота консоли
        public int height { get; }
        //соотношение высотаы и ширины
        public float aspect { get; }
        //соотношение высоты и ширины символа
        public float pixelAspect { get; }
        //множитель (фокусное расстояние) 
        public float multiplier { get; }
        //Массив символов
        public char[] buffer { get; private set; }

        public Graphics(int width, int height, float multiplier)
        {
            this.width = width;
            this.height = height;
            this.multiplier = multiplier;
            aspect = (float)width / height;
            pixelAspect = 8.0f / 12.0f;
            buffer = new char[width * height];
        }

        //Чистим (заполняем буффер пробелами)
        private void Reset()
        {
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    buffer[i + j * width] = ' ';
        }

        public void Begin() // обнуляет буффер и положение курсора в консоли
        {
            Reset();
            Console.SetCursorPosition(0, 0);
        }

        public void Draw(Shape shape) // Добавляет форму в буффер
        {
            // дров у шейп должно возвращать изменёный массив чаров где добавилась форма
            char[] shapeBuffer = shape.Draw(this);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (shapeBuffer[i + j * width] != 0)
                        buffer[i + j * width] = shapeBuffer[i + j * width];
                }
            }
        }

        public void WriteEnd() // Выводит буфер в консоль
        {
            Console.WriteLine(buffer);
        }
    }
}
