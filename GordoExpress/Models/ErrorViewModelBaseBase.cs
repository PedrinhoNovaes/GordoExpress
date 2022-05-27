namespace GordoExpress.Models
{
    public class ErrorViewModelBaseBase
    {
        private string requestId;

        public string? RequestId { get => requestId; set => requestId = value; }
    }
}