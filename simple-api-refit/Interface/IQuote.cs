using Refit;
using simple_api_refit.Model;

namespace simple_api_refit.Interface
{
    public interface IQuote
    {
        [Get("")]
        Task<QuoteKanyeWest> ReturnQuote();
    }
}
