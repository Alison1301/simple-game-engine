public class SnakeSegment{
    private int x; //the x position of this snake segment
    private int y; //the y position of this snake segment
    private int prevX; //the previous x position of this snake segment
    private int prevY; //the previous y position of this snake segment

    private char character; //the character representing this snake segment visually

    public SnakeSegment(int x, int y, char character){

        this.x = x;
        this.y = y;
        this.character=character;
    }

    public int X {
        get {return x;}
        set {
            x = prevX;
        }
    }

    public int Y {
        get {return y;}
        set {
            y = prevY;
        }
    }

    public int PrevX {
        get {return prevX;}
    }

    public int PrevY {
        get {return prevY;}
    }

    public char Character{
        get {return character;}
    }
}