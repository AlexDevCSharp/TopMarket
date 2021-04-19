using System.Threading.Tasks;

namespace TopMarket.Client.Helpers
{
    interface IDisplayMessage
    {
        ValueTask DisplayErrorMessage(string message);
        ValueTask DisplaySuccessMessage(string message);
    }
}
