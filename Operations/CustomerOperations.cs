using CircularDependencyApi.Interfaces;

namespace CircularDependencyApi.Operations
{
    public class CustomerOperations
    {
        private readonly IEMailOperations _eMailOperations;
        private readonly ISMSOperations _smsOperations;

        public CustomerOperations(
            IEMailOperations eMailOperations,
            ISMSOperations smsOperations)
        {
            _eMailOperations = eMailOperations;
            _smsOperations = smsOperations;
        }
        public void SendReport()
        {
            _eMailOperations.GetEMailOperation();
            _smsOperations.GetSmsOperation();
        }
    }
}
