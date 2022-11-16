/*Se le solicita realizar el juego de TOTITO únicamente con las herramientas enseñadas durante el curso.
Donde se pueda jugar contra la maquina y contra otra persona.
Queda a su creatividad el diseño del juego.*/

//Establecer el tamaño de pantalla
using System;

Console.SetWindowSize(100, 40);

int conteo = 0;//variable para realizar las repeciones del juego 
int opcion;//opcion del menu

//Inicializar espacios para evaluar si las posiciones estan vacias
char casilla1 = ' ';
char casilla2 = ' ';
char casilla3 = ' ';
char casilla4 = ' ';
char casilla5 = ' ';
char casilla6 = ' ';
char casilla7 = ' ';
char casilla8 = ' ';
char casilla9 = ' ';


bool turnoRobot = true;
bool turnoJugador = false;




Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("                      MENU  ");
Console.WriteLine("                     TOTITO  ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("1. Jugar contra robot");
Console.WriteLine("2. Jugar con un amigo");
Console.WriteLine("3. Salir \n");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Ingese la opcion que desea: ");
opcion = Convert.ToInt32(Console.ReadLine());
Console.Clear();


if (opcion == 1)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    string nom;
    Console.WriteLine("¿Quien eres?: ");
    nom = Convert.ToString(Console.ReadLine());
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Jugador 1 (X): " + nom + "\n" + "Jugador 2 (0): Robot");

    //Figura del totito LADO HORIZONTAL
    for (int i = 0; i < 15; i++)
    {

        //lado de arriba horizontal
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(8 + i, 6);//POSICION EN PANTALLA
        Console.WriteLine("*");
        Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG
                        //Lado de abajo horizontal 
        Console.SetCursorPosition(8 + i, 8);
        Console.WriteLine("*");
        Thread.Sleep(1);   //ESTO ES UNA PAUSA DE 1SEG

    }

    //Figura del totito LADO VERTICAL
    for (int i = 0; i < 7; i++)
    {
        //Lado izquierdo vertical 
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(13, 4 + i);
        Console.WriteLine("*");

        Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG

        //Lado derecho vertical 
        Console.SetCursorPosition(17, 4 + i);
        Console.WriteLine("*");
        Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG
    }

    //REPITIENDO EL JUEGO
    while (conteo < 10)
    {


        //CICLO DE LOS TURNOS
        if (turnoRobot)
        {

            //Generar el tiro de el robot
            Random random = new Random();
            int tiro = random.Next(1, 10);

            if (tiro == 1)
            {
                if (casilla1 == ' ')
                {
                    //Posicion 1
                    Console.SetCursorPosition(10, 5);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("0");

                    casilla1 = '0';//Llenar posicion

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;

                }



            }
            else if (tiro == 2)
            {
                if (casilla2 == ' ')
                {
                    //Posicion 2
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(15, 5);
                    Console.WriteLine("0");

                    casilla2 = '0';//Llenar posicion

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }




            }
            else if (tiro == 3)
            {
                if (casilla3 == ' ')
                {
                    //Posicion 3
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(19, 5);
                    Console.WriteLine("0");

                    casilla3 = '0';//Llenar posicion

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;

                }


            }
            else if (tiro == 4)
            {
                if (casilla4 == ' ')
                {
                    //Posicion 4
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(10, 7);
                    Console.WriteLine("0");

                    casilla4 = '0';

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }




            }
            else if (tiro == 5)
            {
                if (casilla5 == ' ')
                {
                    //Posicion 5
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(15, 7);
                    Console.WriteLine("0");

                    casilla5 = '0';

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }



            }
            else if (tiro == 6)
            {
                if (casilla6 == ' ')
                {
                    //Posicion 6
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(19, 7);
                    Console.WriteLine("0");

                    casilla6 = '0';

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }



            }
            else if (tiro == 7)
            {
                if (casilla7 == ' ')
                {
                    //Posicion 7
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(10, 9);
                    Console.WriteLine("0");

                    casilla7 = '0';//Llenar casilla

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;

                }



            }
            else if (tiro == 8)
            {
                if (casilla8 == ' ')
                {
                    //Posicion 8
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(15, 9);
                    Console.WriteLine("0");

                    casilla8 = '0';//

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }

            }
            else if (tiro == 9)
            {
                if (casilla9 == ' ')
                {
                    //Posicion 9
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(19, 9);
                    Console.WriteLine("0");

                    casilla9 = '0';//Llenar posicion

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;


                }

            }



            //COMPARACION EN CASILLAS PARA SABER SI GANO
            //1,2 y 3 gano
            if (casilla1 == casilla2 && casilla3 == casilla1)
            {
                if (casilla1 == '0' && casilla2 == '0' && casilla3 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡EL robot Gano!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //4, 5 y 6 gano
            if (casilla4 == casilla5 && casilla6 == casilla4)
            {
                if (casilla4 == '0' && casilla5 == '0' && casilla6 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡EL robot Gano!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }

            //7,8 y 9 gano
            if (casilla7 == casilla8 && casilla9 == casilla7)
            {
                if (casilla7 == '0' && casilla8 == '0' && casilla9 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡EL robot Gano!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }


            }

            //1,4 y 7 gano
            if (casilla1 == casilla4 && casilla7 == casilla1)
            {
                if (casilla1 == '0' && casilla4 == '0' && casilla7 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡EL robot Gano!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //2,5 y 8 gano 
            if (casilla2 == casilla5 && casilla8 == casilla2)
            {
                if (casilla2 == '0' && casilla5 == '0' && casilla8 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡EL robot Gano!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //3,6 y 9 gano 
            if (casilla3 == casilla6 && casilla3 == casilla9)
            {

                if (casilla3 == '0' && casilla6 == '0' && casilla9 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡EL robot Gano!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //3,5, Y 7 gano
            if (casilla3 == casilla5 && casilla7 == casilla7)
            {

                if (casilla3 == '0' && casilla5 == '0' && casilla7 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡EL robot Gano!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }

            //1, 5 y 9 gano
            if (casilla1 == casilla5 && casilla9 == casilla1)
            {

                if (casilla1 == '0' && casilla5 == '0' && casilla9 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡EL robot Gano!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }



        }



        //TIRA DEL JUGADOR
        if (turnoJugador)
        {
            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese la posicion del tiro que desea hacer: 1. 2. 3. 4. 5. 6. 7. 8. 9.");
            int op1 = Convert.ToInt32(Console.ReadLine());

            //TIROS DEL JUGADOR
            if (op1 == 1)
            {
                if (casilla1 == ' ')
                {
                    //Posicion 1
                    Console.SetCursorPosition(10, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");


                    casilla1 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena: ");



                }

            }
            else if (op1 == 2)
            {
                if (casilla2 == ' ')
                {
                    //Posicion 2
                    Console.SetCursorPosition(15, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");

                    casilla2 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena: ");
                }

            }
            else if (op1 == 3)
            {
                if (casilla3 == ' ')
                {
                    //Posicion 3
                    Console.SetCursorPosition(19, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");

                    casilla3 = 'X';//Llenar posicion

                    //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (op1 == 4)
            {
                if (casilla4 == ' ')
                {
                    //Posicion 4
                    Console.SetCursorPosition(10, 7);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");

                    casilla4 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (op1 == 5)
            {
                if (casilla5 == ' ')
                {
                    //Posicion 5
                    Console.SetCursorPosition(15, 7);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");

                    casilla5 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (op1 == 6)
            {
                if (casilla6 == ' ')
                {
                    //Posicion 6
                    Console.SetCursorPosition(19, 7);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");


                    casilla6 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (op1 == 7)
            {
                if (casilla7 == ' ')
                {
                    //Posicion 7
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 9);
                    Console.WriteLine("X");


                    casilla7 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }


            }
            else if (op1 == 8)
            {
                if (casilla8 == ' ')
                {
                    //Posicion 8
                    Console.SetCursorPosition(15, 9);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");


                    casilla8 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (op1 == 9)
            {
                if (casilla9 == ' ')
                {
                    //Posicion 9
                    Console.SetCursorPosition(19, 9);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");
                    Console.SetCursorPosition(0, 18);

                    casilla9 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }


            }




            // COMPARACION EN CASILLAS PARA SABER SI GANO
            //1, 2 y 3 gano
            if (casilla1 == casilla2 && casilla3 == casilla1)
            {
                if (casilla1 == 'X' && casilla2 == 'X' && casilla3 == 'X')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }
            //4, 5 y 6 gano
            if (casilla4 == casilla5 && casilla6 == casilla4)
            {
                if (casilla4 == 'X' && casilla5 == 'X' && casilla6 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }

            //7,8 y 9 gano
            if (casilla7 == casilla8 && casilla9 == casilla7)
            {
                if (casilla7 == 'X' && casilla8 == 'X' && casilla9 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }


            }

            //1,4 y 7 gano
            if (casilla1 == casilla4 && casilla7 == casilla1)
            {
                if (casilla1 == 'X' && casilla4 == 'X' && casilla7 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   

                }

            }

            //2,5 y 8 gano 
            if (casilla2 == casilla5 && casilla8 == casilla2)
            {
                if (casilla2 == 'X' && casilla5 == 'X' && casilla8 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //3,6 y 9 gano 
            if (casilla3 == casilla6 && casilla3 == casilla9)
            {

                if (casilla3 == 'X' && casilla6 == 'X' && casilla9 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //7,5 y 3 gano
            if (casilla7 == casilla5 && casilla3 == casilla7)
            {

                if (casilla7 == 'X' && casilla5 == 'X' && casilla3 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }

            //1, 5 y 9 gano
            if (casilla1 == casilla5 && casilla9 == casilla1)
            {

                if (casilla1 == 'X' && casilla5 == 'X' && casilla9 == 'X')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!");
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';


                    break;//Rompe el siclo   
                }

            }





        }
        conteo++;
    }
}
else if (opcion == 2)
{
    //NOMBRE DE PRIMER JUGADOR
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("¿Jugador 1?: ");
    String nombre1 = Convert.ToString(Console.ReadLine());
    Console.Clear();
    //NOMBRE DEL SEGUNDO JUGADOR
    Console.WriteLine("¿Jugador 2?: ");
    String nombre2= Convert.ToString(Console.ReadLine());
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Clear();

    Console.WriteLine("Jugador 1 (0): " + nombre1 + "\n" + "Jugador 2 (X): " +nombre2);

    //Figura del totito LADO HORIZONTAL
    for (int i = 0; i < 15; i++)
    {

        //lado de arriba horizontal
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(8 + i, 6);//POSICION EN PANTALLA
        Console.WriteLine("*");
        Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG
                        //Lado de abajo horizontal 
        Console.SetCursorPosition(8 + i, 8);
        Console.WriteLine("*");
        Thread.Sleep(1);   //ESTO ES UNA PAUSA DE 1SEG

    }

    //Figura del totito LADO VERTICAL
    for (int i = 0; i < 7; i++)
    {
        //Lado izquierdo vertical 
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(13, 4 + i);
        Console.WriteLine("*");

        Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG

        //Lado derecho vertical 
        Console.SetCursorPosition(17, 4 + i);
        Console.WriteLine("*");
        Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG
    }

    //REPITIENDO EL JUEGO
    while (conteo < 10)
    {
        //CICLO DE LOS TURNOS
        if (turnoRobot)
        {
            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese la posicion del tiro que desea hacer: 1. 2. 3. 4. 5. 6. 7. 8. 9.");
            int jugador1 = Convert.ToInt32(Console.ReadLine());


            if (jugador1 == 1)
            {
                if (casilla1 == ' ')
                {
                    //Posicion 1
                    Console.SetCursorPosition(10, 5);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("0");

                    casilla1 = '0';//Llenar posicion

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;

                }



            }
            else if (jugador1 == 2)
            {
                if (casilla2 == ' ')
                {
                    //Posicion 2
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(15, 5);
                    Console.WriteLine("0");

                    casilla2 = '0';//Llenar posicion

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }




            }
            else if (jugador1 == 3)
            {
                if (casilla3 == ' ')
                {
                    //Posicion 3
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(19, 5);
                    Console.WriteLine("0");

                    casilla3 = '0';//Llenar posicion

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;

                }


            }
            else if (jugador1 == 4)
            {
                if (casilla4 == ' ')
                {
                    //Posicion 4
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(10, 7);
                    Console.WriteLine("0");

                    casilla4 = '0';

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }




            }
            else if (jugador1 == 5)
            {
                if (casilla5 == ' ')
                {
                    //Posicion 5
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(15, 7);
                    Console.WriteLine("0");

                    casilla5 = '0';

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }



            }
            else if (jugador1 == 6)
            {
                if (casilla6 == ' ')
                {
                    //Posicion 6
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(19, 7);
                    Console.WriteLine("0");

                    casilla6 = '0';

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }



            }
            else if (jugador1 == 7)
            {
                if (casilla7 == ' ')
                {
                    //Posicion 7
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(10, 9);
                    Console.WriteLine("0");

                    casilla7 = '0';//Llenar casilla

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;

                }



            }
            else if (jugador1 == 8)
            {
                if (casilla8 == ' ')
                {
                    //Posicion 8
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(15, 9);
                    Console.WriteLine("0");

                    casilla8 = '0';//

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;
                }

            }
            else if (jugador1 == 9)
            {
                if (casilla9 == ' ')
                {
                    //Posicion 9
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(19, 9);
                    Console.WriteLine("0");

                    casilla9 = '0';//Llenar posicion

                    turnoJugador = true;//Habilitar turno jugador 
                    turnoRobot = false;


                }

            }



            //COMPARACION EN CASILLAS PARA SABER SI GANO
            //1,2 y 3 gano
            if (casilla1 == casilla2 && casilla3 == casilla1)
            {
                if (casilla1 == '0' && casilla2 == '0' && casilla3 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡Usted Gano " + nombre1);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //4, 5 y 6 gano
            if (casilla4 == casilla5 && casilla6 == casilla4)
            {
                if (casilla4 == '0' && casilla5 == '0' && casilla6 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡Usted Gano " + nombre1);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }

            //7,8 y 9 gano
            if (casilla7 == casilla8 && casilla9 == casilla7)
            {
                if (casilla7 == '0' && casilla8 == '0' && casilla9 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡Usted Gano " + nombre1);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }


            }

            //1,4 y 7 gano
            if (casilla1 == casilla4 && casilla7 == casilla1)
            {
                if (casilla1 == '0' && casilla4 == '0' && casilla7 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡Usted Gano " + nombre1);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //2,5 y 8 gano 
            if (casilla2 == casilla5 && casilla8 == casilla2)
            {
                if (casilla2 == '0' && casilla5 == '0' && casilla8 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡Usted Gano " + nombre1);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //3,6 y 9 gano 
            if (casilla3 == casilla6 && casilla3 == casilla9)
            {

                if (casilla3 == '0' && casilla6 == '0' && casilla9 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡Usted Gano " + nombre1);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //3,5, Y 7 gano
            if (casilla3 == casilla5 && casilla7 == casilla7)
            {

                if (casilla3 == '0' && casilla5 == '0' && casilla7 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡Usted Gano " + nombre1);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }

            //1, 5 y 9 gano
            if (casilla1 == casilla5 && casilla9 == casilla1)
            {

                if (casilla1 == '0' && casilla5 == '0' && casilla9 == '0')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("¡Usted Gano " + nombre1);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }



        }

        //TIRA DEL JUGADOR 2
        if (turnoJugador)
        {
            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese la posicion del tiro que desea hacer: 1. 2. 3. 4. 5. 6. 7. 8. 9.");
            int jugador2 = Convert.ToInt32(Console.ReadLine());

            //TIROS DEL JUGADOR 2
            if (jugador2 == 1)
            {
                if (casilla1 == ' ')
                {
                    //Posicion 1
                    Console.SetCursorPosition(10, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");


                    casilla1 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena: ");



                }

            }
            else if (jugador2 == 2)
            {
                if (casilla2 == ' ')
                {
                    //Posicion 2
                    Console.SetCursorPosition(15, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");

                    casilla2 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena: ");
                }

            }
            else if (jugador2 == 3)
            {
                if (casilla3 == ' ')
                {
                    //Posicion 3
                    Console.SetCursorPosition(19, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");

                    casilla3 = 'X';//Llenar posicion

                    //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (jugador2 == 4)
            {
                if (casilla4 == ' ')
                {
                    //Posicion 4
                    Console.SetCursorPosition(10, 7);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");

                    casilla4 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (jugador2 == 5)
            {
                if (casilla5 == ' ')
                {
                    //Posicion 5
                    Console.SetCursorPosition(15, 7);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");

                    casilla5 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (jugador2 == 6)
            {
                if (casilla6 == ' ')
                {
                    //Posicion 6
                    Console.SetCursorPosition(19, 7);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");


                    casilla6 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (jugador2 == 7)
            {
                if (casilla7 == ' ')
                {
                    //Posicion 7
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 9);
                    Console.WriteLine("X");


                    casilla7 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }


            }
            else if (jugador2 == 8)
            {
                if (casilla8 == ' ')
                {
                    //Posicion 8
                    Console.SetCursorPosition(15, 9);
                    Console.WriteLine("X");


                    casilla8 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }

            }
            else if (jugador2 == 9)
            {
                if (casilla9 == ' ')
                {
                    //Posicion 9
                    Console.SetCursorPosition(19, 9);
                    Console.WriteLine("X");
                    Console.SetCursorPosition(0, 18);

                    Console.ForegroundColor = ConsoleColor.Red;
                    casilla9 = 'X';//Llenar posicion
                                   //Cambiar turno
                    turnoRobot = true;
                    turnoJugador = false;
                }
                else
                {
                    Console.WriteLine("La posicion ya esta llena ");
                }


            }




            // COMPARACION EN CASILLAS PARA SABER SI GANO
            //1, 2 y 3 gano
            if (casilla1 == casilla2 && casilla3 == casilla1)
            {
                if (casilla1 == 'X' && casilla2 == 'X' && casilla3 == 'X')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!" + nombre2);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }
            //4, 5 y 6 gano
            if (casilla4 == casilla5 && casilla6 == casilla4)
            {
                if (casilla4 == 'X' && casilla5 == 'X' && casilla6 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!" + nombre2);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }

            //7,8 y 9 gano
            if (casilla7 == casilla8 && casilla9 == casilla7)
            {
                if (casilla7 == 'X' && casilla8 == 'X' && casilla9 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!" + nombre2);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }


            }

            //1,4 y 7 gano
            if (casilla1 == casilla4 && casilla7 == casilla1)
            {
                if (casilla1 == 'X' && casilla4 == 'X' && casilla7 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!" + nombre2);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   

                }

            }

            //2,5 y 8 gano 
            if (casilla2 == casilla5 && casilla8 == casilla2)
            {
                if (casilla2 == 'X' && casilla5 == 'X' && casilla8 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!" + nombre2);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //3,6 y 9 gano 
            if (casilla3 == casilla6 && casilla3 == casilla9)
            {

                if (casilla3 == 'X' && casilla6 == 'X' && casilla9 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!" + nombre2);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }

            }

            //7,5 y 3 gano
            if (casilla7 == casilla5 && casilla3 == casilla7)
            {

                if (casilla7 == 'X' && casilla5 == 'X' && casilla3 == 'X')
                {

                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!" + nombre2);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';

                    break;//Rompe el siclo   
                }
            }

            //1, 5 y 9 gano
            if (casilla1 == casilla5 && casilla9 == casilla1)
            {

                if (casilla1 == 'X' && casilla5 == 'X' && casilla9 == 'X')
                {
                    Console.SetCursorPosition(5, 17);
                    Console.WriteLine("!USTED GANO!" + nombre2);
                    //Recetear casillas
                    casilla1 = ' ';
                    casilla2 = ' ';
                    casilla3 = ' ';
                    casilla4 = ' ';
                    casilla5 = ' ';
                    casilla6 = ' ';
                    casilla7 = ' ';
                    casilla8 = ' ';
                    casilla9 = ' ';


                    break;//Rompe el siclo   
                }

            }





        }
        conteo++;
    }

}
else if (opcion == 3)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;//Color letras
    Console.WriteLine("¡EL programa a finalizado!");
    Environment.Exit(0);//Finalizar el programa
}

Console.WriteLine("\n");
Console.ForegroundColor = ConsoleColor.White;




