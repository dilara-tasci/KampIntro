using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class CampaignManager : ICampaignService
    {
        Campaign _campaign;
        public CampaignManager(Campaign campaign)
        {
            _campaign = campaign;
        }
        public void Add()
        {
            Console.WriteLine("Kampanya Kaydı Gerçekleştirildi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
