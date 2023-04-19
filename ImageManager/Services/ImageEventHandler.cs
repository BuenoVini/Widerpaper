namespace ImageManager.Services;

public class ImageEventHandler
{
    public event EventHandler<ImageUploadedEventArgs>? ImageUploaded;
    
    public void OnImageUploaded(string filePath) => ImageUploaded?.Invoke(this, new ImageUploadedEventArgs(filePath)); 
}

public class ImageUploadedEventArgs
{
    public string FilePath { get; }
    public ImageUploadedEventArgs(string filePath) => FilePath = filePath;
}