using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    public static class GameSettings
    {
        public static int Rows { get; private set; } = 6;
        public static int Cols { get; private set; } = 4;

        public static int SelectedSizeIndex { get; private set; } = 0;

        public static event Action<int, int>? lauaSuurus;

        public static void SeaLauaSuurus(int rows, int cols, int selectedIndex)
        {
            Rows = rows;
            Cols = cols;
            SelectedSizeIndex = selectedIndex;
            lauaSuurus?.Invoke(rows, cols);
        }
    }

}
