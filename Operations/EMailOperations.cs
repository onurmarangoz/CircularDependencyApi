using CircularDependencyApi.Interfaces;

namespace CircularDependencyApi.Operations
{
    public class EMailOperations : IEMailOperations
    {
        private readonly ISMSOperations _smsOperations;

        public EMailOperations(ISMSOperations smsOperations)
        {
                _smsOperations = smsOperations;
        }

        public void GetEMailOperation()
        {
            _smsOperations.GetSmsOperation();
        }
    }
}
