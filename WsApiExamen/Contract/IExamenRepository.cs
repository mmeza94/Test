using WsApiExamen.Dto;
using WsApiExamen.Entities;

namespace WsApiExamen.Contract
{
    public interface IExamenRepository
    {
        Task<ExamenDto> InsertExamen(Examen examen);
        Task<ExamenDto> DeleteExamen(int Id);
        Task<ExamenDto> UpdateExamen(int Id, string Descripcion, string Nombre);
        Task<List<Examen>> GetExamen(int Id, string Descripcion, string Nombre);

    }
}
