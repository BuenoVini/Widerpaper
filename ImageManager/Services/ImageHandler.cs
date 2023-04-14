namespace ImageManager.Services;

public class ImageHandler : IDisposable
{
    private readonly Image<Rgba32> _imageInput;
    private Image<Rgba32> _imageOutput;

    #region Constructor and Dispose
    public ImageHandler(string filePath)
    {
        _imageInput = Image.Load<Rgba32>(filePath);
        _imageOutput = new Image<Rgba32>(_imageInput.Height * 21 / 9, _imageInput.Height);
    }

    public void Dispose()
    {
        _imageInput.Dispose();
        _imageOutput.Dispose();
    }
    #endregion

    public void ToUltrawideMirroed()
    {
        int n = (_imageOutput.Width - _imageInput.Width) / 2;

        for (int y = 0; y < _imageInput.Height; y++)
        {
            int xOutput, xInput;
            
            for (xOutput = 0, xInput = n - 1; xInput >= 0; xOutput++, xInput--)
                _imageOutput[xOutput, y] = _imageInput[xInput, y];

            for (xInput = 0; xInput < _imageInput.Width; xOutput++, xInput++)
                _imageOutput[xOutput, y] = _imageInput[xInput, y];

            for (xInput = _imageInput.Width - 1; xInput >= _imageInput.Width - n; xOutput++, xInput--)
                _imageOutput[xOutput, y] = _imageInput[xInput, y];
        }
        
        _imageOutput.Save("result.png");
    }
}