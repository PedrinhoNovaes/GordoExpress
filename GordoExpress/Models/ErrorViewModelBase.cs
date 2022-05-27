namespace GordoExpress.Models
{
    public class ErrorViewModelBase : ErrorViewModelBaseBase
    {
        private string requestId;

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}