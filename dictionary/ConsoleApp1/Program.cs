using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        void Run()
        {
            Room startRoom = new Room(0, 0, new string[]
            {
                "xxxxx",
                "x...x",
                "x...x",
                "x...x",
                "xxxxx"
            });

            Room room1 = new Room(0, 1, new string[]
            {
                "xxxxx",
                "x...x",
                "x...x",
                "x...x",
                "xxxxx"
            });
            Room room2 = new Room(0, 2, new string[]
            {
                "xxxxx",
                "x...x",
                "x...x",
                "x...x",
                "xxxxx"
            });

            rooms.Add(startRoom.GetRoomLocationKey(), startRoom);
            rooms.Add(room1.GetRoomLocationKey(), room1);
            rooms.Add(room2.GetRoomLocationKey(), room2);


            ShowRoom(0, 0);
            ShowRoom(0, 1);
            ShowRoom(0, 2);
            ShowRoom(0, 3);




            Console.ReadLine();
        }

         void ShowRoom(int x, int y)
        {

            bool hasRoom = rooms.ContainsKey($"{x}, {y}");
            string key = $"{x},{y}";

            if (rooms.ContainsKey(key) && hasRoom )
            {
                
                    Room room = rooms[key];
                    Console.WriteLine($"You are in room {x}, {y}");
                    foreach (string r in room.level)
                    {
                        Console.WriteLine(r);
                    }
                
            }else if (!hasRoom)
            {
                Console.WriteLine("Room does not exist");
            }

        }
        
    }

    class Room
    {
        internal int x, y;
        internal string[] level;

        internal Room(int x, int y, string[] level)
        {
            this.x = x;
            this.y = y;
            this.level = level;
        }
        
        internal string GetRoomLocationKey()
        {
            return $"{x},{y}";
        }
    }
}
