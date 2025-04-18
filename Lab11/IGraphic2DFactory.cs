namespace Lab11;

public interface IGrahic2DFactory
{
    string Name {get; protected set;} 

    IGraphic2D Create();

}