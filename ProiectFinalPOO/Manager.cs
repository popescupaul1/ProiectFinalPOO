using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace ProiectFinalPOO
{
    public class Manager
    {
        private List<Client> clienti;

        public Manager(string dirPath)
        {
            clienti = new List<Client>();
            LoadUsers(dirPath);
        }

        public void LoadUsers(string directoryPath)
        {
            var files = Directory.GetFiles(directoryPath, "*.txt");
            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);

                // Ensure the file has the expected number of lines to avoid index out of range
                if (lines.Length < 7)
                {
                    Console.WriteLine($"File {file} does not contain enough data.");
                    continue;
                }

                try
                {
                    Client client = new Client
                    {
                        Nume = lines[0].Split(':')[1].Trim(),
                        Parola = lines[1].Split(':')[1].Trim(),
                        Adresa = lines[2].Split(':')[1].Trim(),
                        CIF = lines[3].Split(':')[1].Trim(),
                        Banca = lines[4].Split(':')[1].Trim(),
                        RegCom = lines[5].Split(':')[1].Trim(),
                        Cont = lines[6].Split(':')[1].Trim()
                    };
                    clienti.Add(client);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Error processing file {file}: {ex.Message}");
                }
            }
        }

        public Client Authenticate(string name, string password)
        {
            foreach (var client in clienti)
            {
                if (client.Nume == name && client.Parola == password)
                {
                    return client;
                }
            }
            return null;
        }
    }
}
