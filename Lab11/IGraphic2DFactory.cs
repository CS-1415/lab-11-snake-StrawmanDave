namespace Lab11;

public interface IGraphic2DFactory
{
    string Name {get; protected set;} 

    IGraphic2D Create();

}