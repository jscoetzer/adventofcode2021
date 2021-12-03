namespace adventofcode2021.utils
{
    public class FileUtil
    {
        public static string[] readLines(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(@path);
            return lines;
        }
    }
}