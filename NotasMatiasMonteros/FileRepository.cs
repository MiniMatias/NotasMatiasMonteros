using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasMatiasMonteros
{
    class FileRepository
    {
        private string filepath = FileSystem.AppDataDirectory+"/archivo.txt";
        public async Task<bool> GenerarArchivoAsync(string texto)
        {
            try
            {
                await File.WriteAllTextAsync(filepath, texto);
                if (File.Exists(filepath))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                 return false;
            }
        }

        public async Task<string> DevuelveInformacionArchivoAsync()
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string texto = await File.ReadAllTextAsync(filepath);
                    return texto;
                }
                return "El archivo no existe.";
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
