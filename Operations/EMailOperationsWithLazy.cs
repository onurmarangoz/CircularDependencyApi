using CircularDependencyApi.Interfaces;

namespace CircularDependencyApi.Operations
{
    public class EMailOperationsWithLazy : IEMailOperations
    {
        private readonly Lazy<ISMSOperations> _smsOperations;

        public EMailOperationsWithLazy(Lazy<ISMSOperations> smsOperations)
        {
            _smsOperations = smsOperations;
        }

        public void GetEMailOperation()
        {
            _smsOperations.Value.GetSmsOperation();
        }
    }
}

