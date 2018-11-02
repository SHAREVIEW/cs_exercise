测试面试题

if语句：

{
            double number,temp;         
            
            double balance = 10000;
            Console.WriteLine("You have {0} yuan at present.", balance);
            Console.WriteLine("1:Save \n2:draw \n3:Quit");

            Console.WriteLine("Please enter a number:");
            number = Convert.ToDouble(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Please enter how much money that you want to save:");
                temp = Convert.ToDouble(Console.ReadLine());
                balance += temp;
                Console.WriteLine("Total money is: {0}.", balance);
                Console.ReadKey();
            }
            else if (number == 2)
            {
                Console.WriteLine("Please enter how much money that you want to draw:");
                temp = Convert.ToDouble(Console.ReadLine());
                balance -= temp;
                Console.WriteLine("Total money is: {0}.", balance);
                Console.ReadKey();

            }
            else if (number == 3)
            {

                Console.WriteLine("Quit");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong");
                Console.ReadKey();

            }
                