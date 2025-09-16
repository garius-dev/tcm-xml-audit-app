using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Extensions
{
    public static class FileExtensions
    {
        public static void CopyFileReplacingIfExists(string sourcePath, string destinationFolder, string? renameAs)
        {
            if (string.IsNullOrWhiteSpace(sourcePath) || string.IsNullOrWhiteSpace(destinationFolder))
            {
                Console.WriteLine("Erro: Caminho de origem ou destino inválido.");
                return;
            }

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Erro: O arquivo de origem não existe.");
                return;
            }

            try
            {
                // Garante que a pasta de destino exista
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                    Console.WriteLine("Pasta de destino criada.");
                }

                string fileName = Path.GetFileName(sourcePath);
                string destinationPath = Path.Combine(destinationFolder, fileName);

                if(!string.IsNullOrWhiteSpace(renameAs))
                {
                    string extension = Path.GetExtension(fileName);
                    destinationPath = Path.Combine(destinationFolder, renameAs + extension);
                }

                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);
                    Console.WriteLine("Arquivo de destino existente removido.");
                }

                File.Copy(sourcePath, destinationPath);
                Console.WriteLine("Arquivo copiado com sucesso.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Erro: Permissão negada para acessar os arquivos.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro de E/S: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        public static void CopyFilesToFolder(List<FileInfo> files, string destinationFolder, string? renameAs = null)
        {
            if(files == null || files.Count == 0)
            {
                Console.WriteLine("Nenhum arquivo para copiar.");
                return;
            }

            foreach(var file in files)
            {
                CopyFileReplacingIfExists(file.FullName, destinationFolder, renameAs);
            }
        }

        public static List<FileInfo> GetFiles(string folderPath, string extension, string? prefix = null, string? suffix = null)
        {
            if (string.IsNullOrWhiteSpace(folderPath))
                throw new ArgumentException("O caminho da pasta não pode ser nulo ou vazio.", nameof(folderPath));

            if (!Directory.Exists(folderPath))
                throw new DirectoryNotFoundException($"A pasta '{folderPath}' não existe.");

            var directory = new DirectoryInfo(folderPath);

            string[] searchPatterns = extension.Split('|');
            List<FileInfo> files = new List<FileInfo>();
            foreach (string sp in searchPatterns)
            {
                files.AddRange(directory.GetFiles(sp));
            }

            //FileInfo[] files = directory.GetFiles(extension);

            return files
                .Where(file =>
                {
                    var name = Path.GetFileNameWithoutExtension(file.Name);

                    bool matchesPrefix = string.IsNullOrEmpty(prefix) || name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase);
                    bool matchesSuffix = string.IsNullOrEmpty(suffix) || name.EndsWith(suffix, StringComparison.OrdinalIgnoreCase);

                    return matchesPrefix && matchesSuffix;
                })
                .ToList();
        }
    }
}
