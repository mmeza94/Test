using Microsoft.EntityFrameworkCore;
using WsApiExamen.Contract;
using WsApiExamen.Dto;
using WsApiExamen.Entities;

namespace WsApiExamen.DataAccess
{
    public class ExamenRepository: IExamenRepository
    {
        private readonly ExamenDbContext context;

        public ExamenRepository(ExamenDbContext context)
        {
            this.context = context;
        }


        public async Task<List<Examen>> GetExamen(int Id, string Descripcion, string Nombre)
        {
            var examenes = await context.Examenes
                    .Where(ex => ex.Id == Id || ex.Nombre == Nombre || ex.Descripcion == Descripcion).ToListAsync();
            return examenes;
        } 


        public async Task<ExamenDto> UpdateExamen(int Id, string Descripcion, string Nombre)
        {
            bool success = false;
            string message = string.Empty;

            try
            {
                var examen  = new Examen { Id = Id, Nombre = Nombre, Descripcion = Descripcion };
                context.Examenes.Update(examen);
                await context.SaveChangesAsync();
                success = true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                success = false;

            }

            return new ExamenDto
            {
                Success = success,
                Message = message
            };
        }


        public async Task<ExamenDto> DeleteExamen(int Id) 
        {
            bool success = false;
            string message = string.Empty;

            try
            {
                var examen = await context.Examenes.FirstOrDefaultAsync(ex => ex.Id == Id);
                context.Examenes.Remove(examen);
                await context.SaveChangesAsync();
                success = true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                success = false;

            }

            return new ExamenDto
            {
                Success = success,
                Message = message
            };

        }


        public async Task<ExamenDto> InsertExamen(Examen examen)
        {
            bool success = false;
            string message = string.Empty;

            try
            {
                context.Examenes.Add(examen);
                await context.SaveChangesAsync();
                success = true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                success = false;

            }

            return new ExamenDto
            {
                Success = success,
                Message = message
            };
            
        }

   
    }

}
