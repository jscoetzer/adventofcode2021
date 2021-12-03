using adventofcode2021.utils;

namespace adventofcode2021
{
    public class Solution
    {
        private string inputPath { get; set; }
        private string[] input { get; set; }

        public Solution(string inputPath)
        {
            this.inputPath = inputPath;
            this.input = FileUtil.readLines(inputPath);
        }
    }
}