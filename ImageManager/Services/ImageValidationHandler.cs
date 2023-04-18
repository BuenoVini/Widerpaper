namespace ImageManager.Services;

public static class ImageValidationHandler
{
    private static readonly string[] PermittedExtensions = {".jpg", ".jpeg", ".png"};

    private static readonly Dictionary<string, byte[]> FileSignature = new()
    {
        { ".jpg", new byte[] { 0xFF, 0xD8 } },
        { ".jpeg", new byte[] { 0xFF, 0xD8 } },
        { ".png", new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A } },
    };

    public static bool IsImageSupported(Stream file, string path) => NameValidation(path) && 
                                                            ExtensionValidation(path) &&
                                                            SignatureValidation(file, path);

    private static bool NameValidation(string filePath) => !string.IsNullOrEmpty(filePath);
    private static bool ExtensionValidation(string filePath) => PermittedExtensions.Contains(Path.GetExtension(filePath).ToLower());

    private static bool SignatureValidation(Stream fileStream, string filePath)
    {
        string extension = Path.GetExtension(filePath);

        byte[] fileHeaderBytes = new BinaryReader(fileStream).ReadBytes(FileSignature[extension].Length);
        return FileSignature[extension].SequenceEqual(fileHeaderBytes);
    }

}