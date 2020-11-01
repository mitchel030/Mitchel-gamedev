using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private enum States
    {
        start,
        intro,
        Boot,
        dood,
        lopen,
        Man,
        geluid,
        Koekje,
        Huis,
        Raam,
        binnen,
        Boos,
        Geweer,


    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainmenu();
    }

    void Update()
    {
        print(currentState);
    }
    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "credits")
            {
                Terminal.WriteLine("Gemaakt door: Aron van de Ridder");
            }
            else
            {
                Terminal.WriteLine("Typ start...");
            }
        }

        else if (currentState == States.intro)
        {
            if (input == "")
            {
                Boot();
            }
            else if (input == "lopen")
            {

            }
        }

        else if (currentState == States.Boot)
        {
            if (input == "rennen")
            {
                Rennen();
            }
            else if (input == "lopen")
            {
                lopen();
            }
        }

        else if (currentState == States.intro)
        {
            if (input == "rennen")
            {
                Rennen();
            }
            else if (input == "lopen")
            {

            }
        }
        else if (currentState == States.dood)
        {
            if (input == "menu")
            {
                ShowMainmenu();
            }
        }

        else if (currentState == States.Man)
        {
            if (input == "")
            {
                Koekje();
            }

        }
        else if (currentState == States.Koekje)
        {
            if (input == "menu")
            {
                ShowMainmenu();
            }

        }
        else if (currentState == States.geluid)
        {
            if (input == "")
            {
                Huis();
            }

        }
        else if (currentState == States.Huis)
        {
            if (input == "Raam")
            {
                Raam();
            }
            else if (input == "binnen")
            {
                binnen();
            }
        }
        else if (currentState == States.binnen)
        {
            if (input == "")
            {
                Geweer();
            }
        }
        else if (currentState == States.geluid)
        {
            if (input == "")
            {
                Koekje();
            }

        }
        else if (currentState == States.lopen)
        {
            if (input == "lopen")
            {
                man();
            }
            else if (input == "rennen")
            {
                Huis();
            }

        }
        else if (currentState == States.Huis)
        {
            if (input == "steen")
            {
                Raam();
            }
            else if (input == "rennen")
            {
                binnen();
            }

        }
        else if (currentState == States.Geweer)
        {
            if (input == "wegrennen")
            {
                schuil();
            }
            else if (input == "toegaan")
            {
                naarman();
            }

        }



    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een warme dag");
        Terminal.WriteLine("je staat op een hele mooie boot");
        Terminal.WriteLine("Je roeit naar de kant");
        currentState = States.intro;
    }

    void ShowMainmenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij Kapsones");
        Terminal.WriteLine("Dit is zo nep als het maar kan");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("Typ start om te beginnen...");
        currentState = States.start;

    }

    void Boot()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je staat aan de kant.");
        Terminal.WriteLine("Wil je rennen of lopen?");
        currentState = States.Boot;
    }

    void Rennen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent dood omdat je te moe was");
        Terminal.WriteLine("Typ menu om opnieuw te beginnen!");
        currentState = States.dood;
    }


    void lopen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hoort geluiden van een man.");
        Terminal.WriteLine("Wil je naar hem Lopen of van hem weg");
        Terminal.WriteLine(" rennen?");
        currentState = States.lopen;
    }

    void man()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De man bied je een koekje aan.");
        Terminal.WriteLine("Je eet het koekje op");
        currentState = States.Man;
    }

    void Koekje()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Gefeliciteerd je hebt de game gewonnen!.");
        Terminal.WriteLine("Typ menu om terug te gaan");
        currentState = States.Koekje;
    }

    void Huis()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ziet een huis.");
        Terminal.WriteLine("Je ziet een koekje");
        Terminal.WriteLine("Wil je naar binnen of alleen het koekje ");
        Terminal.WriteLine("pakken?");
        Terminal.WriteLine("Typ steen om alleen het koekje te");
        Terminal.WriteLine("pakken");
        Terminal.WriteLine("Typ binnen om naar binnen te gaan");
        currentState = States.Huis;
    }

    void Raam()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je slaat het raam in en pakt een koekje.");
        Terminal.WriteLine("Je eet het koekje op");
        currentState = States.Raam;
    }

    void binnen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat naar binnen.");
        Terminal.WriteLine("Een man vraagt aan je wat je binnen doet.");
        Terminal.WriteLine("Je rent weg.");
        currentState = States.binnen;
    }

    void Geweer()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hij schiet op je.");
        Terminal.WriteLine("Wil je naar hem toe gaan of wegrennen.");lopen
        Terminal.WriteLine("Typ toegaan om naar hem toe te gaan.");
        Terminal.WriteLine("Typ wegrennen om te schuilen.");
        currentState = States.Geweer;
    }


}