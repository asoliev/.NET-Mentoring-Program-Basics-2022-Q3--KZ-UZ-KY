using FileCabinet.Models;

namespace FileCabinet
{
    public interface IProvider
    {
        void Write(BaseDocument document);

        BaseDocument Read(int id);
    }
}