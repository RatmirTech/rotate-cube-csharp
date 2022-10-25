namespace CubeOfRubick.Models
{
    public class Cube
    {
        public IList<Cell> Cells { get; set; }

        public IList<Row> Rows { get; set; }

        public IList<Column> Columns { get; set; }

        public IList<Color> Colors { get; set; }

        public IList<CubeCells> CubeCells { get; set; }
    }
}
