

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.data;

namespace WebApp.estudante
{
    public static class RotasEstudantes
    {
        public static void AddRotasEstudantes(this WebApplication app)
        {

            var rotasEstudante = app.MapGroup(prefix: "estudantes");

            app.MapPost(pattern: "", handler: async (EstudanteRequest request, AppDBContext context) =>
            {
                var novoEstaduante = new Estudantes(request.Name, true, request.Curso);
                await context.Estudante.AddAsync(novoEstaduante);
                await context.SaveChangesAsync();
            });

            app.MapGet("/Mostraestudantes", async (AppDBContext context) => // Mantendo os mesmos parâmetros
            {
                var estudantes = await context.Estudante.ToListAsync(); // Corrigi o nome do DbSet
                return new JsonResult(estudantes);// Corrigi o retorno de Response
            });

            app.MapGet("/mostrausuario/{name}", async(AppDBContext context, string name) => { 

                var estudantes = await context.Estudante.FirstOrDefaultAsync(e => e.Name == name);
                return new JsonResult(estudantes);
                
            });


            



        }
    }
}