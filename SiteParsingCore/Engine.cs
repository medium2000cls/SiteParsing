using System.Threading;

namespace SiteParsingCore
{
    public class Engine
    {
        private IDataExtraction _dataExtraction;
        private IDataProcessing _dataProcessing;
        

        public Engine(IDataExtraction dataExtraction, IDataProcessing dataProcessing)
        {
            _dataExtraction = dataExtraction;
            _dataProcessing = dataProcessing;
        }

        private Thread Worker()
        {
            throw new System.NotImplementedException();
        }

        public void CheckingTheLastPrice()
        {
        }
    }
    
    
    
}