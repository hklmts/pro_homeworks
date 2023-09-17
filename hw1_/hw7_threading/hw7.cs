using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_.hw7_threading
{
    public class SleepingBarber
    {
        public void Barber()
        {
            Random Rand = new Random();
            const int MaxCustomers = 3;
            const int NumChairs = 1;
            Semaphore restRoom = new Semaphore (NumChairs, NumChairs);
            Semaphore barberChair = new Semaphore (1, 3);
            Semaphore barberSleepChair = new Semaphore (0, 3);
            Semaphore seatBelt = new Semaphore (0, 3);
            bool AllDone = false;
            void Barber()
            {
                while (!AllDone)
                {
                    Console.WriteLine("Barber sleep or drink coffee...");
                    barberSleepChair.WaitOne();
                    if (!AllDone)
                    {
                        Console.WriteLine("Barber cuts...");
                        Thread.Sleep(Rand.Next(1, 3) * 1000);
                        Console.WriteLine("Barber cut!");
                        seatBelt.Release();
                    }
                    else
                    {
                        Console.WriteLine("Barber sleep or drink coffee...");
                    }
                }
                return;
            }
            void Customer(Object number)
            {
                int Number = (int)number;
                Console.WriteLine("Customer {0} goes to barbershop...", Number);
                Thread.Sleep(Rand.Next(1, 5) * 500);
                Console.WriteLine("Customer {0} came!", Number);
                restRoom.WaitOne();
                Console.WriteLine("Customer {0} goes into restroom...", Number);
                barberChair.WaitOne();
                restRoom.Release();
                Console.WriteLine("Customer {0} wakes up the barber...", Number);
                barberSleepChair.Release();
                seatBelt.WaitOne();
                barberChair.Release();
                Console.WriteLine("Customer {0} leavs barbershop...", Number);
            }
            Thread BarberThread = new Thread(Barber);
            BarberThread.Start();
            Thread[] Customers = new Thread[MaxCustomers];
            for (int i = 0; i < MaxCustomers; i++)
            {
                Customers[i] = new Thread(new ParameterizedThreadStart(Customer));
                Customers[i].Start(i);
            }
            for (int i = 0; i < MaxCustomers; i++)
            {
                Customers[i].Join();
            }
            AllDone = true;
            barberSleepChair.Release();
            BarberThread.Join();
            Console.WriteLine("End of work");
        }
    }
}
