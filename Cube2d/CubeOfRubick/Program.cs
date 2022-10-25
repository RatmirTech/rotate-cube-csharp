using CubeOfRubick.Models;
Console.WriteLine("RatmirTech, Cube");
Cube cube = new Cube();

IList<Side> sides = new List<Side>();
for (int i = 0; i < 6; i++)
{
    Side side = new Side();
    side.Id = i;
    sides.Add(side);
}

//для себя
IList<Color> colors = new List<Color>()
{
    new Color(0, "жёлтый", ConsoleColor.Yellow),
    new Color(1, "красный", ConsoleColor.Red),
    new Color(2, "синий", ConsoleColor.Blue),
    new Color(3, "зелёный", ConsoleColor.Green),
    new Color(4, "оранжевый", ConsoleColor.DarkYellow),
    new Color(5, "белый", ConsoleColor.White)
};

IList<Column> columns = new List<Column>();
for (int i = 0; i < 3; i++)
{
    Column column = new Column();
    column.Id = i;
    columns.Add(column);
}

IList<Row> rows = new List<Row>();
for (int i = 0; i < 3; i++)
{
    Row row = new Row(i);
    rows.Add(row);
}

IList<CubeCells> cubeCells = new List<CubeCells>();
for (int i = 0; i < 54; i++)
{
    CubeCells cubeCell = new CubeCells();
    cubeCells.Add(cubeCell);
}

IList<Cell> cells = new List<Cell>();

for (int i = 0; i < 54; i++)
{
    Cell cell = new Cell();
    cell.Name = $"{i}";
    cell.Id = i;
    cell.CubeCellId = i;
    if (i < 9)
    {
        cell.SideId = 0;
        cell.ColorCode = ConsoleColor.Yellow;
    }
    else if (i > 8 && i < 18)
    {
        cell.SideId = 1;
        cell.ColorCode = ConsoleColor.Red;
    }
    else if (i > 17 && i < 28)
    {
        cell.SideId = 2;
        cell.ColorCode = ConsoleColor.Blue;
    }
    else if (i > 27 && i < 37)
    {
        cell.SideId = 3;
        cell.ColorCode = ConsoleColor.Green;
    }
    else if (i > 36 && i < 45)
    {
        cell.SideId = 4;
        cell.ColorCode = ConsoleColor.DarkYellow;
    }
    else if (i > 44 && i < 55)
    {
        cell.SideId = 5;
        cell.ColorCode = ConsoleColor.White;
    }
    cells.Add(cell);
}

int k = 0;
foreach (var cell in cells)
{
    k++;
    if (k < 3)
    {
        Console.BackgroundColor = cell.ColorCode;
        Console.Write(cell.Name);
    }
    else if (k >= 3)
    {
        k = 0;
        Console.WriteLine(cell.Name);
    }
}