using PumpServiceServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpClient
{
    public class CallBackHandler : IPumpServiceCallback
    {
        public void UpdateStatistic(StatisticService statistics)
        {
            Console.Clear();

            Console.WriteLine("Обновление статистики");
            Console.WriteLine("Всего" + statistics.AllTacts);
            Console.WriteLine("Успех" + statistics.SuccessTacts);
            Console.WriteLine("Ошибок" + statistics.ErrorTacts);            
        }
    }
}
