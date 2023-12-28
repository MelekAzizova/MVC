using NuGet.Packaging.Signing;

namespace Restorant.Helpers
{
    public static class FileExtension
    {
        public static bool IsValidSize(this IFormFile file, float kb=30) => file.Length <= kb * 1024;
        public static bool IsValidType(this IFormFile file, string type="image")=>file.ContentType.Contains(type);
        public static async Task<string> SaveAsync(this IFormFile file, string path)
        {
            string extension = Path.GetExtension(file.FileName);
            string fileName=Path.GetFileName(file.FileName).Length >32 ?
                file.FileName.Substring(0,32) :
                Path.GetFileName(file.FileName);
            fileName = Path.Combine(path, Path.GetRandomFileName() + fileName + extension);
            using(FileStream fs=File.Create(Path.Combine(PathConst.RootPath,path)))
            {
                await file.CopyToAsync(fs);
            }
            return fileName;
        }
    }
}
