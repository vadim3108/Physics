namespace Physics
{
    public interface IPosition
    {
        Vector ReferencePoint { get; set; }
        Vector PositionFromReference { get; set; }
    }
}