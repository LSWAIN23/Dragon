﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to see a dragon?");
            Console.WriteLine("Yes or no");
            string result = Console.ReadLine();

            if(result == "no")
            {
                Console.WriteLine("Aww, poor baby");
                Console.WriteLine(@"
                                                lllllll_______
                                     _,_  llllllllllll\
                        ___         /   \  llllllllllll\
                           \       | @ @ |  llllllllllll\
                            \-----oOO---Ooo-------------/
                             \lllllllllllllllllllllllll/
                              \lllllllllllllllllllllll/
                               \lllllllllllllllllllll/
                                    //            \
                                   ||             ||
                                   OO             OO
                                                                    ");
            }

            if (result == "yes")
            {
                Console.WriteLine(@"           
                                                                                        ,d888*`
                                                                                      ,d888`
                                                                                    ,d888`
                                                                                   ,d88`
                                                                                 ,d88`
                                                                                ,d8`
                                                                              ,d8*                   ..d**
                                                                            ,d88*             ..d **`
                                                                          ,d88`         ..d8*`
                                                                        ,d888`    ..d8P*`
                                                                .     ,d8888*8888*`
                                                              ,*     ,88888*8P*
                                                            ,*      d888888*8b.
                                                          ,P       dP  *888.*888b.
                                                        ,8        8     *888   `**88888b.
                                                      ,dP                 88          *88b.
                                                     d8`                  *8b              *8b.
                                                   ,d8`                    *8.                 *88b.
                                                  d8P                       88.                    *88b
                                                ,88P                        888
                                               d888*       .d88P            888
                                              d8888b..d888888*              888
                                            ,888888888888888b.              888
                                           ,8*;88888P*****788888888ba.      888
                                          ,8;,8888*         `88888*         d88*
                                          )8e888*           ,88888be.       888
                                         ,d888`           ,8888888***     d888
                                        ,d88P`           ,8888888Pb.     d888`
                                        888*             ,88888888** .d8888*
                                        `88            ,888888888.d88888b
                                         `P           ,8888888888bd888888*
                                                      d888888888888d888*
                                                      8888888888888888b.
                                                      88*. *88888888888b.        .db
                                                      `888b. `8888888888888b. .d8888P
                                                       **88b. `*8888888888888888888888b...
                                                        *888b. `*8888888888P***7888888888888e.
                                                         88888b. `********.d8888b**`88888P*
                                                         `888888b      .d88888888888 * *`8888.
                                                          )888888.    d888888888888P   `8888888b.
                                                         ,88888*     d88888888888 * *`    `8888b
                                                        ,8888*     .8888888888P`          `888b.
                                                       ,888*       888888888b...            `888P88b.
                                             .db.  ,d88*           88888888888888b          `8888
                                          ,d888888b.8888`          `*888888888888888888P`   `888b.
                                         /*****8888b**`               `***8888P*``8888`       `8888b.
                                              /**88`                  .ed8b..  .d888P`            `88888
                                                                    d8**888888888P*               `88b
                                                                   (*``,d8888***`                    `88
                                                                      (*`                             `88
                                                                                                       88
                                                                                                      88
                                                                                                     `8
                                                                                                     d8
              ");
            }

        }
    }
}