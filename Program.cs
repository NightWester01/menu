using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Меню
{
    class Program
    {
        //ПИ-126 Гольдин Георгий 
        static void DrawFrame2(int left, int top, int width, int height)
        {
            string horizontalLine2 = new string('═', width - 2);
            Console.SetCursorPosition(left + 2, top);
            Console.Write(horizontalLine2);
            Console.SetCursorPosition(left + 1, top + height - 3);
            Console.Write(horizontalLine2);

            Console.SetCursorPosition(left + 25, top + 23);
            Console.WriteLine("Спасибо за покупку");
            Console.SetCursorPosition(left + 50, top + 32);

            Console.SetCursorPosition(left, top);
            Console.Write("╔");
            Console.SetCursorPosition(left + width - 1, top);
            Console.Write("╗");
            Console.SetCursorPosition(left, top + height - 1);
            Console.Write("╚");
            Console.SetCursorPosition(left + width - 1, top + height - 1);
            Console.Write("╝");

            string horizontalLine = new string('═', width - 2);
            Console.SetCursorPosition(left + 1, top);
            Console.Write(horizontalLine);
            Console.SetCursorPosition(left + 1, top + height - 1);
            Console.Write(horizontalLine);


            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("║");
                Console.SetCursorPosition(left + width - 1, top + i);
                Console.Write("║");
            };

            Console.SetCursorPosition(left+49, top+24);
            Console.Write("╦");
            Console.SetCursorPosition(left + 49, top + 25);
            Console.Write("║");
            Console.SetCursorPosition(left + 49, top + 26);
            Console.Write("║");
            Console.SetCursorPosition(left + 49, top + 27);
            Console.Write("║");
            Console.SetCursorPosition(left + 49, top + 28);
            Console.Write("║");
            Console.SetCursorPosition(left + 49, top + 29);
            Console.Write("║");
            Console.SetCursorPosition(left + 49, top +29);
            Console.Write("╩");


            Console.SetCursorPosition(left + 1, top + 26);
            Console.WriteLine("Скидка 5% по промокоду discount");
            Console.SetCursorPosition(left + 1, top + 27);
            Console.Write("При заказе от 2000 рублей");
            Console.SetCursorPosition(left + 50, top + 26);
            Console.WriteLine(DateTime.Now);
        }
        static void PrintReceipt(string[] food)
        {
            int Receipt = 0;
            for (int i = 0; i < 1 ; i++)
            {
                Console.Write("{0},",Receipt);
                Console.WriteLine("Вы выбрали = {0},",food);
            }
            Console.WriteLine();
        }
        static void DrawFrame(int left, int top, int width, int height)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(left +12, top + 1);
            Console.WriteLine("Добро пожаловать в кафе From Russia With Love");
            Console.SetCursorPosition(left+29, top+2);
            Console.WriteLine("Меню");

            string horizontalLine6 = new string('═', width - 2);
            Console.SetCursorPosition(left + 1, top+4);
            Console.Write(horizontalLine6);
            Console.SetCursorPosition(left + 1, top + height - 1);
            Console.Write(horizontalLine6);

            Console.SetCursorPosition(left, top);
            Console.Write("╔");
            Console.SetCursorPosition(left + width - 1, top);
            Console.Write("╗");
            Console.SetCursorPosition(left, top + height - 1);
            Console.Write("╚");
            Console.SetCursorPosition(left + width - 1, top + height - 1);
            Console.Write("╝");

            string horizontalLine = new string('═', width - 2);
            Console.SetCursorPosition(left + 1, top);
            Console.Write(horizontalLine);
            Console.SetCursorPosition(left + 1, top + height - 1);
            Console.Write(horizontalLine);


            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("║");
                Console.SetCursorPosition(left + width - 1, top + i);
                Console.Write("║");
            };
            Console.SetCursorPosition(left + 20, top + 24);
            Console.SetCursorPosition(left + 40, top + 28);
        }
        static void Clear()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
        static void PrintFirst(string[] First,int x, int y, int active)
        {
            for (int i = 0; i < First.Length; i++)
            {
                if (i == active)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(First[i]);
            }
        }
        static void PrintMenu(string[] Second, int x, int y, int active)
        {

            for (int i = 0; i < Second.Length; i++)
            {
                if (i == active)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(Second[i]);
            }
        }
        static int SelectByArrows(string[] menu, int x, int y)
        {
            Console.CursorVisible = false;
            int active = 0;
            bool isWorking = true;
            while (isWorking)
            {
                PrintMenu(menu, x, y, active);
                // ждем нажатия кнопки
                ConsoleKeyInfo info = Console.ReadKey(intercept: true);
                //смотрим что нажато
                switch (info.Key)
                {
                    case ConsoleKey.Enter:
                        isWorking = false;
                        break;
                    case ConsoleKey.UpArrow:
                        active--;
                        break;
                    case ConsoleKey.DownArrow:
                        active++;
                        break;
                }
            }
            Console.CursorVisible = true;
            return active;
        }
        static void Main(string[] args)
        {
            int Price = 0;
            //console user interface- menu
            DrawFrame(5,2,70,30);
            string[] First =
            {
                "Картофель по домашнему = 135rub/170g",
                "картофель жаренный = 100rub/150g",
                "Картофильное пюре = 100rub/150g",
                "Драники картофильные = 110rub/130g",
                "Рис/Гречка/Спагетти = 100rub/150g",
                "Овощи Гриль = 260rub/195g",
                "Овощи,запеченные с сыром = 270rub/190g",
                "Свежие овощи = 170rub/150g",
                "Продолжить"
            };
            PrintReceipt(First);
            DrawFrame(5,2,70,30);
            string[] Second =
            {
                "Салат Царский = 350rub/210g",
                "Салат Цезарь с креветками = 400rub/230g",
                "Теплый салат с говядиной = 450rub/200g",
                "Салат Прионежский = 350rub/200g",
                "Салат мясной = 250rub/150g",
                "Греческий = 300rub/220g",
                "Салат Цезарь с курицей = 300rub/220g",
                "Салат Комплимент = 240rub/155g",
                "Продолжить",
                "Вернуться"
            };
            PrintReceipt(Second);
            DrawFrame(5,2,70,30);
            string[] Bakery =
            {
                "Блины = 50rub/2шт",
                "Сырники = 175rub/3шт ",
                "Творожный пирог = 115rub/100g",
                "Торт (любой) = 230rub/1kg",
                "Чизкейк клубничный = 185rub",
                "Чизкейк брусничный = 185rub",
                "Лаваши = 50rub",
                "Хлебная тарелка = 50rub/any",
                "Продолжить",
                "Вернуться"
            };
            PrintReceipt(Bakery);
            DrawFrame(5,2,70,30);
            string[] Potables =
            {
                "Компот из ягод = 50rub/0.25",
                "Чай черный = 170rub/350ml",
                "Сок апельсиновый = 50rub/0.2L",
                "Кока кола = 100rub/2L",
                "Sprite = 100rub/2L",
                "Fanta 100rub/2L",
                "Кофе = 120rub/any",
                "Продолжить",
                "Вернуться"
            };
            PrintReceipt(Potables);
            DrawFrame(5,2,70,30);
            string[] Cold_snacks =
            {
                "Рыбное ассорти = 435rub/200g",
                "Рулетики из форели = 390rub/180g",
                "Игра красная порционная = 345rub/50g",
                "Язык с хреном = 290rub/100g",
                "Мясное ассорти = 390rub/150g",
                "Сырное ассорти = 390rub/240g",
                "Продолжить",
                "Вернуться"
            };
            PrintReceipt(Cold_snacks);
            Clear();
            DrawFrame(5,2,70,30);
            int choice1 = SelectByArrows(First, 20, 8);
            if (choice1==0)
            {
                Price =135;
            }
            if (choice1==1)
            {
                Price = 100;
            }
            if (choice1==2)
            {
                Price =100;
            }
            if (choice1==3)
            {
                Price = 110;
            }
            if (choice1==4)
            {
                Price =100;
            }
            if (choice1==5)
            {
                Price = 260;
            }
            if (choice1==6)
            {
                Price = 270;
            }
            if (choice1==7)
            {
                Price = 170;
            }
            if (choice1==8)
            {
                Price = 0;
            }
            Clear();
            DrawFrame(5,2,70,30);
            int choice2 = SelectByArrows(Second, 20, 8);
            if (choice2==0)
            {
                Price = Price + 350;
            }
            if (choice2==1)
            {
                Price = Price + 400;
            }
            if (choice2==2)
            {
                Price = Price + 450;
            }
            if (choice2==3)
            {
                Price = Price + 350;
            }
            if (choice2==4)
            {
                Price = Price + 250;
            }
            if (choice2==5)
            {
                Price = Price + 300;
            }
            if (choice2==6)
            {
                Price = Price + 300;
            }
            if (choice2==7)
            {
                Price = Price + 240;
            }
            if (choice2==8)
            {
                Price = Price + 0;
            }
            if (choice2==9)
            {
                int choice = SelectByArrows(First, 20, 8);
                if (choice2==10)
                {
                    Price = Price + 0;
                }
            }
            Clear();
            DrawFrame(5,2,70,30);
            int choice3 = SelectByArrows(Potables, 20, 8);
            if (choice3==0)
            {
                Price = Price + 50;
            }
            if (choice3==1)
            {
                Price = Price + 175;
            }
            if (choice3==2)
            {
                Price = Price + 115;
            }
            if (choice3==3)
            {
                Price = Price + 230;
            }
            if (choice3==4)
            {
                Price = Price + 185;
            }
            if (choice3==5)
            {
                Price = Price + 185;
            }
            if (choice3==6)
            {
                Price = Price + 50;
            }
            if (choice3==7)
            {
                Price = Price + 50;
            }
            if (choice3==8)
            {
                Price = Price + 0;
            }
            if (choice3==9)
            {
                int choice = SelectByArrows(Second, 20, 8);
                if (choice3==10)
                {
                    Price = Price + 0;
                }
            }
            Clear();
            DrawFrame(5,2,70,30);
            int choice4 = SelectByArrows(Bakery, 20, 8);
            if (choice4==0)
            {
                Price = Price + 50;
            }
            if (choice4==1)
            {
                Price = Price + 170;
            }
            if (choice4==2)
            {
                Price = Price + 50;
            }
            if (choice4==3)
            {
                Price = Price + 100;
            }
            if (choice4==4)
            {
                Price = Price + 100;
            }
            if (choice4==5)
            {
                Price = Price + 100;
            }
            if (choice4==6)
            {
                Price = Price + 120;
            }
            if (choice4==7)
            {
                Price = Price + 0;
            }
            if (choice4==8)
            {
                int choice = SelectByArrows(Potables, 20, 8);
                if (choice4==9)
                {
                    Price = Price + 0;
                }
            }
            Clear();
            DrawFrame(5,2,70,30);
            int choice5 = SelectByArrows(Cold_snacks, 20, 8);
            if (choice5==0)
            {
                Price = Price + 435;
            }
            if (choice5==1)
            {
                Price = Price + 390;
            }
            if (choice5==2)
            {
                Price = Price + 345;
            }
            if (choice5==3)
            {
                Price = Price + 290;
            }
            if (choice5==4)
            {
                Price = Price + 390;
            }
            if (choice5==5)
            {
                Price = Price + 390;
            }
            if (choice5==6)
            {
                Price = Price + 0;
            }
            if (choice5==7)
            {
                int choice = SelectByArrows(Bakery, 20, 8);
                if (choice5==8)
                {
                    Price = Price + 0;
                }
            }
            Clear();
            DrawFrame(5, 2, 70, 30);
            DrawFrame2(5, 2, 70, 25);
            Console.SetCursorPosition(25,9);
            string num = "Ваш номер столика:";
            Console.WriteLine(num);
            Console.SetCursorPosition(45, 9);
            Console.ReadLine();
            Console.SetCursorPosition(25,10);
            string receipt = "Ваш итоговый заказ состоит из:";
            Console.WriteLine(receipt);
            DrawFrame(5, 2, 70, 30);
            Console.SetCursorPosition(18,12);
            Console.WriteLine("1 позиция=>{0},",First[choice1]);
            Console.SetCursorPosition(18, 13);
            Console.WriteLine("2 позиция=>{0},",Second[choice2]);
            Console.SetCursorPosition(18, 14);
            Console.WriteLine("3 позиция=>{0},",Potables[choice3]);
            Console.SetCursorPosition(18, 15);
            Console.WriteLine("4 позиция=>{0},",Bakery[choice4]);
            Console.SetCursorPosition(18, 16);
            Console.WriteLine("5 позиция=>{0},",Cold_snacks[choice5]);
            Console.SetCursorPosition(30, 19);
            Console.WriteLine("К оплате={0}",Price);
            Console.ReadLine();
        }
    }
}
