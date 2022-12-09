using PumpClientNet.PumpClientServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpClientNet
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
