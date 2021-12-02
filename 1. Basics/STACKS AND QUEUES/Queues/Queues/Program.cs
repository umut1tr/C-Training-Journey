using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> ordersQueue = new Queue<Order>();           

            foreach(Order o in RecieveOrdersFromBranch1())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrdersFromBranch2())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            // as long as the queue is not empty
            while(ordersQueue.Count > 0)
            {
                //remove the order At the front of the queue
                //and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //process the order
                currentOrder.ProcessOrder();
            }

            Console.ReadLine();

        }

        static Order[] RecieveOrdersFromBranch1()
        {
            //creating new orders array
            Order[] orders = new Order[]
            {
                    new Order(1,5),
                    new Order(2, 4),
                    new Order(6, 10)
            };
            return orders;
        }

        static Order[] RecieveOrdersFromBranch2()
        {
            //creating new orders array
            Order[] orders = new Order[]
            {
                    new Order(3,5),
                    new Order(4, 4),
                    new Order(5, 10)
            };
            return orders;
        }


        class Order
        {
            // order ID 
            public int OrderId { get; set; }

            // quantity of the order
            public int OrderQuantity { get; set; }

            // simple constructor

            public Order(int id, int orderQuantity)
            {
                this.OrderId = id;
                this.OrderQuantity = orderQuantity;
            }

            // print message on the screen that the order was processed
            public void ProcessOrder()
            {
                // print the message
                Console.WriteLine($"Order {OrderId} processed!.");
            }
        }
    }
}
