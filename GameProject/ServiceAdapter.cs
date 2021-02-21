using CustomerServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ServiceAdapter : ICustomerCheckManager
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync((new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.Identity), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth))))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
