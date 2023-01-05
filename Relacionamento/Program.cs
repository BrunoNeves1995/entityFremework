
using introducao.Data;
using introducao.Model;
using Microsoft.EntityFrameworkCore;

namespace Relacionamento
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            using (var context = new DataContext())
            {
                // context.Users?.Add(new User
                // {
                //     Name = "André Baltieri",
                //     Slug = "andrebaltieri",
                //     Email = "andre@balta.io",
                //     Bio = "9x Microsoft MVP",
                //     Image = "https://balta.io",
                //     PasswordHash = "123098457",
                //     github = "andre@gitbub"
                // });

                // context.SaveChanges();

               
                var user = await context.Users!.FirstOrDefaultAsync(x => x.Id == 1);
                var posts = await context.Posts!.FirstOrDefaultAsync(x => x.Id == 1);
                
                // var post = new Post
                // {
                //     User = user,
                //     Body = "<p>Hello world</p>",
                //     Category = new Category { 
                //         Name = "Web", 
                //         Slug = "web"
                //     },
                //     CreateDate = DateTime.Now,
                //     // LastUpdateDate = 
                //     Slug = "comecando-com-ef-core",
                //     Summary = "Neste artigo vamos aprender EF core",
                //     // Tags = null,
                //     Title = "Meu Artigo",
                   
                // };
                
                // context.Posts?.Add(post);
                // context.SaveChanges();

                var postss = await GetPost(context);
            }

        
        }
        public static async Task<IEnumerable<Post>> GetPost(DataContext context)
        {
            return await context.Posts!.ToListAsync();
        }
    }
}