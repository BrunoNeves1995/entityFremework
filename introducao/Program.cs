using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Data.SqlTypes;
using System;
using introducao.Data;
using introducao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Introducao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (DataContext context = new())
            {
                var tags = 
                context.Tags 
                ?.AsNoTracking() // estamso informando que nao queremos os metados
                .Where(x => x.Name!.Contains("asp"))
                .ToList(); // antes do ToList() a consulta não é executada no banco 

                if (tags is not null)
                    foreach (var tag in tags) 
                        Console.WriteLine(tag.Name);

            }
        }
    }
}