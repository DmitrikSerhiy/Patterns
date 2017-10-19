using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer Serg = new ProgrammerSerg(new CSharpLanguage());
            Serg.DoWork();
            Serg.EarnMoney();

            Serg.Language = new JavaLanguage();
            Serg.DoWork();
            Serg.EarnMoney();
            //so there is no need to create new extra variable of Programmer 
            //baceuse that one Programmer can do work as CSharpLanguage and as JavaLanguage 
            //it's the main purpuse of Bridge - to seperate abstraction and implementation
        }
    }
}
