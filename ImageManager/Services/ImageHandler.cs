namespace ImageManager.Services;

public class ImageHandler : IDisposable
{
    private readonly Image _imageInput;
    private Image _imageOutput;

    #region Constructor and Dispose
    public ImageHandler(string filePath)
    {
        _imageInput = Image.Load<Rgba32>(filePath);
        _imageOutput = new Image<Rgba32>(_imageInput.Height * 21/9, _imageInput.Height);
    }

    public void Dispose()
    {
        _imageInput.Dispose();
        _imageOutput.Dispose();
    }
    #endregion
}