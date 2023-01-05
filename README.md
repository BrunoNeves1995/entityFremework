# Entity Fremework
Curso de EF


### DataContext
   - É o unico objeto que o EF precisa, que define o banco de dados em memória.
      - É composto por subconjuntos de dados Chamado DbSet, que representa as tabelas.
   - Para a classe DataContext ser um DbConetxt, precisamos herda de  :DbConetext
   
### Exemplo: Deixando as entidades disponiveis no contexto
  
     public class DataContext : DbContext
    {
        public DbSet<Category>? Categorys { get; set; }   
    }
    
### Configurnado conexão com DataContext
 
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"AQUI TEM SUA CONNECTION_STRING");

### Exemplo Inserir: Abrindo uma conexão com o banco de dados (Recomendamos usar o using)
   
      using (DataContext context = new())
            {
                Tag tag = new Tag{Name= "Asp.Net", Slug= "aspnet" };
                
                //deixa o arquivo em memoria
                context.Tags?.Add(tag);
                
                //salva o arquivo no banco
                context.SaveChanges();

            }
            
### Exemplo Atualizar
      using (DataContext context = new())
      { 
           var tag = context.Tags?.FirstOrDefault(x => x.Id == 2);
           if(tag is not null)
           {   
              tag.Name = "teste";
              context.Tags?.Update(tag);
              context.SaveChanges();
          }    
    }
        


### Exemplo Deletar
     using (DataContext context = new())
     {
          try
          {
              var tag = context.Tags?.FirstOrDefault(x => x.Id == 2);
              if (tag is not null)
              {
                  context.Tags?.Remove(tag);
                  context.SaveChanges();
              }
          }
          catch (System.Exception)
          {
               Console.WriteLine("erro ao excluir");
          }
    }
    
    
### Exemplo Consultar
      static void Main(string[] args)
      {
          using (DataContext context = new())
          {
              var tags = 
              context.Tags
              ?.Where(x => x.Name!.Contains("asp"))
              .ToList(); // antes do ToList() a consulta não é executada no banco, é apenas montada a consulta 

              if (tags is not null)
                  foreach (var tag in tags) 
                      Console.WriteLine(tag.Name);
          }
      }
      
### AsNoTracking
   - Metadados, sao informações adicional da classe que esta sendo executada. 
      - São trazidos por padrão, porem se não vamos atualizar ou remover, nao precisamos dessas infromações.
   - Podemos então informa para o EF que nao queremos os metadados na consluta. Para isso devemos usar (AsNoTracking)
      
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
# Mapeamento
   
   
   

