using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Village
    {
        public static int numberofVillages = 0;
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;

        public Village() { Village.numberofVillages++; }
    }
    class Countryside
    {
        public Village Maple;

        public Village Toronto;
        public Village Ajax;

        public void MapInitializer()
        {
            Maple = new Village();
            Maple.VillageName = "Maple";
            Maple.previousVillage = null;
            Maple.nextVillage = Toronto;
            Toronto = new Village();
            Toronto.previousVillage = Maple;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Ajax = new Village();
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;
            //tyt

        }
        public void LookForAstrilde()
        {

        }
    }
