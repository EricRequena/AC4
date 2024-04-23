namespace AC4.Persistence.DAO
{
    public interface IComarcaDAO
    {
        ComarcaDTO GetComarcaById(int id);
        IEnumerable<ComarcaDTO> GetAllComarcas();
        void AddComarca(ComarcaDTO comarca);
        void UpdateComarca(ComarcaDTO comarca);
        void DeleteComarca(int id);
    }
}