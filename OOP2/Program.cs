using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelFinanceCredit personelFinanceCredit = new PersonelFinanceCredit();
            //personelFinanceCredit.Calculate();
            
            VehicleLoan vehicleLoan= new VehicleLoan();
            //vehicleLoan.Calculate();

            ICreditManager mortgageLoan = new MortgageLoan();
            //mortgageLoan.Calculate();

            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            FileLoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            

            ApplicationManager applicationManager = new ApplicationManager() { };
            applicationManager.Application(vehicleLoan ,new List < ILoggerService > {databaseLoggerService,fileLoggerService,smsLoggerService });

            List<ICreditManager> credits = new List<ICreditManager>() {personelFinanceCredit,vehicleLoan };
            //applicationManager.CreditApplication(credits);
            
            
        }
    }
}
