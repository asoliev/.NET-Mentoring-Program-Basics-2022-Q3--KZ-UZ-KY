using FileCabinet.Models;

namespace FileCabinet
{
    public class DocumentService
    {
        private IProvider Provider { get; }
        public DocumentService(IProvider provider)
        {
            Provider = provider;
        }

        public void Write(BaseDocument document)
        {
            Provider.Write(document);
        }

        public BaseDocument Read(int id)
        {
            return Provider.Read(id);
        }
    }
}