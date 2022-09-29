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
            int hour = waitingTime / 60;
            int minutes = waitingTime % 60;

            Console.WriteLine("Вам осталость ждать всего " + hour + " часа и " + minutes + " минут.");
            Console.ReadKey();
        }
    }
}
