using Demo.ViewModel;

namespace Demo.Queries.DocumentType
{
    public interface IDocumenTypeQueries
    {
        Task<IEnumerable<DocumentTypeViewModel>> GetAll();
    }
}
