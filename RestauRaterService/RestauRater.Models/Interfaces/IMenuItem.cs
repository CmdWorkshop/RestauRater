namespace RestauRater.Models.Interfaces
{
    public interface IMenuItem
    {
        string Name { get; }
        string Description { get; }
        double Price { get; }
        string Category { get; }
    }
}
