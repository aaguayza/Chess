namespace Chess.Models
{
    abstract class Spot
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public Piece? Piece { get; set; }
    }
}
