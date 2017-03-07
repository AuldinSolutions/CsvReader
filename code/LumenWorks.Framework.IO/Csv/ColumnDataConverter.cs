namespace LumenWorks.Framework.IO.Csv
{
    public delegate bool ColumnDataConverter(string value, out object result);
}