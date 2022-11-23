using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto = new ContoCorrente();
            conto.MenuInizialeStart();
        }

        public class ContoCorrente
        {
            private string _cognomeCorrentista;
            public string CognomeCorrentista
            {
                get { return _cognomeCorrentista; }
                set { _cognomeCorrentista = value; }
            }

            private string _nomeCorrentista;

            public string NomeCorrentista
            {
                get { return _nomeCorrentista; }
                set { _nomeCorrentista = value; }
            }

            private decimal _saldo = 0;
            public decimal Saldo
            {
                get { return _saldo; }
                set { _saldo = value; }
            }

            private bool _contoAperto = false;

            public bool ContoAperto
            {
                get { return _contoAperto; }
                set { _contoAperto = value; }
            }

            public ContoCorrente()
            {

            }

            public void MenuInizialeStart()
            {

                Console.WriteLine("==========================================");
                Console.WriteLine("I N T E S A   S A N   M A R C O   B A N K");
                Console.WriteLine("==========================================");

                Console.WriteLine("\n Scegli l'operazione da effettuare:");
                Console.WriteLine("1. APRI NUOVO CONTO CORRENTE");
                Console.WriteLine("2. EFFETTUA UN VERSAMENTO");
                Console.WriteLine("3. EFFETTUA UN PRELEVAMENTO");
                Console.WriteLine("4. ESCI");

                int scelta = int.Parse(Console.ReadLine());

                if (scelta == 1)
                {
                    ApriNuovoContoCorrente();
                }
                else if (scelta == 2)
                {
                    EffettuaVersamento();
                }
                else if (scelta == 3)
                {
                    EffettuaPrelevamento();
                }
                else if (scelta == 4)
                {
                    Console.WriteLine("Chiusura programma in corso");
                }
                else
                {
                    Console.WriteLine("Hai selezionato una voce non valida.");
                    MenuInizialeStart();
                }

            }

            private void ApriNuovoContoCorrente()
            {
                Console.WriteLine("Cognome Correntista: ");
                string Cognome = Console.ReadLine();

                Console.WriteLine("Nome Correntista: ");
                string Nome = Console.ReadLine();

                ContoCorrente c = new ContoCorrente();
                _cognomeCorrentista = Cognome;
                _nomeCorrentista = Nome;
                _saldo = 0;
                _contoAperto = true;
                Console.WriteLine($"Conto corrente nr. 2555411 intestato a: {_cognomeCorrentista} {_nomeCorrentista} aperto correttamente");
                MenuInizialeStart();
            }

            private void EffettuaPrelevamento()
            {
                if (_contoAperto == false)
                {
                    Console.WriteLine("E' necessario aprire un conto prima di effettuare un prelevamento");
                }
                else
                {
                    Console.WriteLine("Inserisci l'importo del prelevamento da effettuare: ");
                    decimal importoPrelevato = Decimal.Parse(Console.ReadLine());

                    if (importoPrelevato > _saldo)
                    {
                        Console.WriteLine("Prelevamento non consentito!!!");
                    }
                    else
                    {
                        Console.WriteLine("Prelevamento effettuato");
                        _saldo -= importoPrelevato;
                        Console.WriteLine($"Nuovo saldo del CC odierno: {_saldo.ToString("N")}");
                    }
                }
                MenuInizialeStart();
            }

            private void EffettuaVersamento()
            {
                if (_contoAperto == false)
                {
                    Console.WriteLine("E' necessario aprire un conto prima di effettuare un versamento");
                }
                else
                {
                    Console.WriteLine("Inserisci l'importo del versamento da effettuare: ");
                    decimal importoVersato = Decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Versamento effettuato");
                    _saldo += importoVersato;
                    Console.WriteLine($"Nuovo saldo del CC odierno: {_saldo.ToString("N")}");
                }
                MenuInizialeStart();
            }


        }
    }
}

