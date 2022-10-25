namespace CubeOfRubick.Models
{
    public class Color
    {
        /// <summary>
        /// Номер цвета
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код цвета
        /// </summary>
        public ConsoleColor Code { get; set; }

        public Color(int id, string name, ConsoleColor code)
        {
            Id = id;
            Name = name;
            Code = code;
        }
    }
}
