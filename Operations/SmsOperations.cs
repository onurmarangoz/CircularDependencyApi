using CircularDependencyApi.Interfaces;

namespace CircularDependencyApi
{
    public class SMSOperations : ISMSOperations
    {
        private readonly IEMailOperations _eMailOperations;

        public SMSOperations(IEMailOperations eMailOperations)
        {
            _eMailOperations = eMailOperations;
        }

        public void GetSmsOperation()
        {
            _eMailOperations.GetEMailOperation();
        }

    }
}
