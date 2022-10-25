namespace CubeOfRubick.Models
{
    public class Cell
    {
        /// <summary>
        /// номер ячейки
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// номер столбца
        /// </summary>
        public int ColumnId { get; set; }

        /// <summary>
        /// Номер строчки
        /// </summary>
        public int RowId { get; set; }

        /// <summary>
        /// Номер цвета
        /// </summary>
        public ConsoleColor ColorCode { get; set; }

        /// <summary>
        /// номер стороны
        /// </summary>
        public int SideId { get; set; }

        /// <summary>
        /// номер ячейки самого куба
        /// </summary>
        public int CubeCellId { get; set; }

        /// <summary>
        /// Символ
        /// </summary>
        public string Name { get; set; }

        //public Cell(int id, int columnId, int rowId, int colorId, int sideId, int cubeCellId, string name)
        //{
        //    Id = id;
        //    ColumnId = columnId;
        //    RowId = rowId;
        //    ColorId = colorId;
        //    SideId = sideId;
        //    CubeCellId = cubeCellId;
        //    Name = name;
        //}
    }
}
