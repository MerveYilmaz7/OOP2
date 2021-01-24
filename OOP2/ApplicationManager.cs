using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class ApplicationManager
    {
        public void Application(ICreditManager creditManager, List<ILoggerService> loggerService) 
        {
            creditManager.Calculate();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void CreditApplication(List<ICreditManager>credit)
        {
            foreach (var credits in credit)
            {
                credits.Calculate();
            }
        }

        
        

    }
    
}
