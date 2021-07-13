using System;
using System.Threading;

namespace BasicallyStudySystem.actions.managers
{
    public class ActionManager : IActions
    {
        private bool _match;
        private string _action;

        public void Execute()
        {
            Console.WriteLine("\n Napisz czynnosc, ktora chcecsz wykonac: ");
                _action = Console.ReadLine();
                _match = Enum.IsDefined(typeof(ActionsType), _action!);
                if (_match)
                {
                    Apply();
                    return;
                }
                Console.WriteLine("Nie odnaleziono takiego typu!");
                Console.WriteLine("Dostepne typy:");
                foreach (var actionType in Enum.GetValues(typeof(ActionsType)))
                {
                    Console.WriteLine($" - {actionType}");
                }
                Rejection();
            }

        public void Apply()
        {
            if (_action.Equals(ActionsType.Ilosc.ToString()))
            {
                new ActionCountManager().Execute();
            }
            else if (_action.Equals(ActionsType.DodajUczen.ToString()))
            {
                new ActionAddManager().Execute();
            } else if (_action.Equals(ActionsType.DodajKlasa.ToString()))
            {
                new ActionAddClassManager().Execute();
            } else if (_action.Equals(ActionsType.Wyszukaj.ToString()))
            {
                new ActionSearchManager().Execute();
            } else if (_action.Equals(ActionsType.Usun.ToString()))
            {
                new ActionRemoveManager().Execute();
            }
            else if (_action.Equals(ActionsType.Zakoncz.ToString()))
            {
                Console.WriteLine("Trwa zamykanie...");
                Environment.Exit(-1);
            }
        }

        public void Rejection()
        {
            Thread.Sleep(3*1000);
            Execute();
        }
    }
}