
internal class Grid {

    // The Grid itself
    public static int w = 10; // this is the width
    public static int h = 13; // this is the height
    public static Element[,] elements = new Element[w, h];

    // Uncover all Mines
    public static void uncoverMines()
    {
        foreach (Element elem in elements)
            if (elem.mine)
                elem.loadTexture(0);
    }
}


