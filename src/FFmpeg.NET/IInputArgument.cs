namespace FFmpeg.NET
{
    public interface IArgument
    {
        string Argument { get; }
    }

    public interface IInputArgument : IArgument, IHasMetaData
    {
    }

    public interface IOutputArgument : IArgument
    {
    }
}
