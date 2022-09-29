using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_at_the_clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int appointmentTime = 25;
            int waitingTime;
            int people;

            Console.WriteLine("Вы находитесь в поликлинике, в очереди на прием доктора, который осматривает одного человека за " + appointmentTime + " минут. Сколько людей перед собой вы видите?");
            people = Convert.ToInt32(Console.ReadLine());
            waitingTime = people * appointmentTime;

            Console.WriteLine("Вам осталость ждать всего " + waitingTime / 60 + " часа и " + waitingTime % 60 + " минут.");
            Console.ReadKey();
        }
    }
}
