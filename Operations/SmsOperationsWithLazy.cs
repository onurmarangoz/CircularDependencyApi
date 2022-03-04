using CircularDependencyApi.Interfaces;
using CircularDependencyApi.Operations;

namespace CircularDependencyApi
{
    public class AOperationsWithLazy : ISMSOperations
    {
        private readonly Lazy<EMailOperationsWithLazy> _bOperations;

        public AOperationsWithLazy(Lazy<EMailOperationsWithLazy> bOperations)
        {
            _bOperations = bOperations;
        }

        public void GetSmsOperation()
        {
            _bOperations.Value.GetEMailOperation();
        }

    }
}
