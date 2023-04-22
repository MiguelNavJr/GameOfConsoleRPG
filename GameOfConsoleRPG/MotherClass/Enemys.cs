﻿using GameOfConsoleRPG.SonClass.enemy;
using GameOfConsoleRPG.SonClass.hero;
using GameOfConsoleRPG.SonClass.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameOfConsoleRPG.MotherClass
{
    public class Enemys
    {
        public string Name;
        public int Hp;
        public int Mana;
        public string Atk1;
        public string Atk2;
        public int Lvl;
        public int x;
        public int y;
        public int velocx;
        public int velocy;

        static bool terminado;
        static Random generador;

        static int numpeon;

        public Enemys(string name, int hp, int mana, string atk1, string atk2, int lvl, int x, int y, int velocx, int velocy) 
        {       
                Name = name;
                Hp = hp;
                Mana = mana;
                Atk1 = atk1;
                Atk2 = atk2;
                Lvl = lvl;
        }

        public EnemyPeon[] GeneradorDeEnemigosPeones(EnemyPeon[] peon)
        {

            terminado = false;
            generador = new Random();

            numpeon = peon.Length - 1;

            //peon[numpeon].velocx = 1;
            for (int i = 0; i < peon.Length; i++)
            {
                if (numpeon >= 0)
                    peon[i].x = generador.Next(10, 50);
                peon[i].y = i * 5 + 3;
                peon[i].Color = peon[numpeon].Color;
                peon[i].Simbolo = peon[numpeon].Simbolo;
                peon[i].velocx = 1;

            }


            return peon;


        }

        public EnemyQueen[] GeneradorDeEnemigosQueen(EnemyQueen[] queen)
        {

            terminado = false;
            generador = new Random();

            numpeon = queen.Length - 1;

            //peon[numpeon].velocx = 1;
            for (int i = 0; i < queen.Length; i++)
            {
                if (numpeon >= 0)
                    queen[i].x = generador.Next(10, 50);
                queen[i].y = i * 5 + 3;
                queen[i].Color = queen[numpeon].Color;
                queen[i].Simbolo = queen[numpeon].Simbolo;
                queen[i].velocx = 1;

            }


            return queen;


        }

        public EnemyKing[] GeneradorDeEnemigosKing(EnemyKing[] king)
        {

            terminado = false;
            generador = new Random();

            numpeon = king.Length - 1;

            //peon[numpeon].velocx = 1;
            for (int i = 0; i < king.Length; i++)
            {
                if (numpeon >= 0)
                    king[i].x = generador.Next(10, 50);
                king[i].y = i * 5 + 3;
                king[i].Color = king[numpeon].Color;
                king[i].Simbolo = king[numpeon].Simbolo;
                king[i].velocx = 1;

            }


            return king;


        }

        public EnemyHorse[] GeneradorDeEnemigosKing(EnemyHorse[] horse)
        {

            terminado = false;
            generador = new Random();

            numpeon = horse.Length - 1;

            //peon[numpeon].velocx = 1;
            for (int i = 0; i < horse.Length; i++)
            {
                if (numpeon >= 0)
                    horse[i].x = generador.Next(10, 50);
                horse[i].y = i * 5 + 3;
                horse[i].Color = horse[numpeon].Color;
                horse[i].Simbolo = horse[numpeon].Simbolo;
                horse[i].velocx = 1;

            }


            return horse;


        }

        public EnemyHorse[] GeneradorDeEnemigosHorse(EnemyKing[] king)
        {

            terminado = false;
            generador = new Random();

            numpeon = king.Length - 1;

            //peon[numpeon].velocx = 1;
            for (int i = 0; i < king.Length; i++)
            {
                if (numpeon >= 0)
                    king[i].x = generador.Next(10, 50);
                king[i].y = i * 5 + 3;
                king[i].Color = king[numpeon].Color;
                king[i].Simbolo = king[numpeon].Simbolo;
                king[i].velocx = 1;

            }


            return king;


        }

        public void AnimarElementos(EnemyPeon[] peon)
        {
            for (int i = 0; i < peon.Length; i++)
            {
                peon[i].x += peon[i].velocx;
                if ((peon[i].x > 60) || (peon[i].x < 10))
                    peon[i].velocx = -peon[i].velocx;
            }
        }

        public bool ComprobarEstadoDelJuegoEnemigos(EnemyPeon[] peon, Mage merlin)
        {
            for (int i = 0; i < peon.Length; i++)
            {
                if ((merlin.X == peon[i].x) && (merlin.Y == peon[i].y))
                {
                    terminado = true;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                                                          Has Muerto                                                         ");
                    Console.WriteLine("                                                           ████████                                                          ");
                    Console.WriteLine("                                          ▒▒▒▒          ████████████▓▓                                                       ");
                    Console.WriteLine("                                      ▒▒▒▒▒▒▒▒        ████████████████▓▓      ▒▒▒▒                                           ");
                    Console.WriteLine("                                   ▒▒    ▒▒▒▒      ▓▓████████████▓▓████▓▓    ▒▒▒▒▒▒▒▒                                        ");
                    Console.WriteLine("                               ░░░░    ░░▒▒▒▒    ▓▓██████████▓▓▓▓▓▓▓▓▓▓██▓▓  ▒▒▒▒    ░░                                      ");
                    Console.WriteLine("                              ▒▒▒▒    ░░░░▒▒▒▒    ████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██  ▒▒▒▒░░  ▓▓▒▒▒▒      ████████████               ");
                    Console.WriteLine("                              ▒▒▒▒    ░░░░▒▒▒▒  ██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▒▒▒▒░░████▓▓▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒████           ");
                    Console.WriteLine("                          ▒▒▒▒▒▒▒▒  ░░░░░░▒▒▒▒  ██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▒▒▒░░██████████▒▒▒▒░░░░░░░░░░░░▒▒▒▒██▓▓       ");
                    Console.WriteLine("                      ▒▒▒▒▒▒  ░░▒▒  ░░░░░░▒▒▒▒  ████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▒▒▒░░████▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒██     ");
                    Console.WriteLine("                  ▒▒▒▒▒▒      ▒▒▒▒░░░░░░▒▒▒▒▒▒  ████████▓▓▓▓▓▓▓▓▓▓▓▓████████▓▓██▒▒░░████▓▓░░░░░░░░            ░░░░░░░░▒▒██   ");
                    Console.WriteLine("               ▒▒▒▒▒▒░░      ▒▒░░░░░░░░░░░░▒▒▒▒██████████▓▓▓▓▓▓██████████████▓▓██▒▒░░████▓▓░░░░    ████████████    ░░░░▒▒▒▒██");
                    Console.WriteLine("             ▒▒▒▒▒▒▒▒    ░░▒▒░░░░░░░░░░░░░░▒▒▒▒██████▓▓▓▓▓▓▓▓████████████████▓▓██▒▒░░██████    ████    ░░▒▒▒▒▒▒████    ░░▒▒██");
                    Console.WriteLine("                  ▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒██████▓▓▓▓▓▓██████████████████▓▓██▒▒░░████████▓▓░░▒▒░░    ▒▒▒▒▒▒▒▒  ██▓▓  ░░▒▒ ");
                    Console.WriteLine("              ▒▒▒▒▒▒▒▒░░░░▒▒▒▒░░░░░░  ▒▒▒▒▒▒▒▒██████▓▓▓▓▓▓████████████████▓▓██▒▒▒▒▒▒████▓▓▒▒▒▒▒▒▒▒░░▒▒░░▒▒            ▓▓  ░░ ");
                    Console.WriteLine("            ▒▒▒▒░░░░░░░░░░▒▒▒▒░░░░    ▒▒▒▒▒▒▒▒██████▓▓▓▓██████████████████▓▓██▒▒▒▒▒▒████▓▓░░░░▒▒▒▒░░░░▒▒▒▒▒▒▒▒          ▓▓   ");
                    Console.WriteLine("            ▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒░░░░░░  ▒▒▒▒▒▒░░░░██████▓▓▓▓████████████████████▒▒▒▒▒▒▒▒▒▒████▓▓░░▒▒▒▒░░░░░░░░░░▒▒▒▒▓          ");
                    Console.WriteLine("                 ▒▒░░▒▒▒▒▒▒▒▒░░▒▒▒▒  ▒▒▒▒░░░░▓▓██████▓▓▓▓▓▓████████████████▒▒░░░░░░▒▒▒▒████▓▓░░░░▒▒▒▒░░░░░░▒▒▒▒▒▒░░          ");
                    Console.WriteLine("                ▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒░░▓▓██▓▓▓▓██████▓▓████████████████░░░░  ░░▒▒▒▒██████▒▒░░▒▒▒▒▒▒▒▒░░▒▒                 ");
                    Console.WriteLine("              ▒▒▒▒░░    ▒▒▒▒▒▒░░░░  ▒▒▓▓██▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓████░░    ░░░░▒▒████▓▓▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒                 ");
                    Console.WriteLine("              ▒▒░░    ▒▒░░░░▒▒░░    ▒▒▒▒██▓▓▓▓▓▓▓▓▓▓██▓▓██████▓▓▓▓████████▒▒▒▒░░░░░░▒▒████▓▓▒▒▒▒▒▒▒▒    ░░▒▒▒▒               ");
                    Console.WriteLine("              ▒▒░░  ▒▒▒▒░░░░▒▒░░  ▒▒▒▒██████▓▓▓▓▓▓▓▓████▓▓██████▓▓▓▓████████▒▒▒▒▒▒▒▒▒▒▓▓████▓▓▒▒░░░░▒▒    ░░▒▒               ");
                    Console.WriteLine("              ▒▒▒▒▒▒▒▒░░  ░░▒▒░░  ▒▒▒▒████████▓▓▓▓██████▓▓▓▓████████▓▓▓▓████████▒▒▒▒▒▒██████████░░░░▒▒▒▒  ▒▒▒▒               ");
                    Console.WriteLine("              ▒▒▒▒░░  ░░  ░░▒▒░░  ▒▒▒▒████████▓▓▓▓▓▓██████▓▓▓▓████▓▓▓▓▓▓████▓▓▓▓██████░░██████░░██  ░░▒▒▒▒▒▒▒▒               ");
                    Console.WriteLine("              ▒▒░░░░  ▒▒    ▒▒░░  ▒▒██████▓▓▓▓██████████████▓▓▓▓▓▓████▓▓██▓▓████▓▓████  ░░██▓▓░░██  ░░  ░░▒▒▒▒               ");
                    Console.WriteLine("              ▒▒░░  ▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒████▓▓██▓▓████  ████████████▓▓▓▓██▓▓██▓▓██▓▓▓▓████░░▓▓░░██▓▓  ░░▒▒  ░░░░▒▒               ");
                    Console.WriteLine("            ▒▒░░░░▒▒▒▒▒▒▒▒    ▒▒▒▒  ████▓▓████████    ████████████████████▓▓██████████▒▒██████▓▓  ▒▒▒▒▒▒  ░░▒▒               ");
                    Console.WriteLine("            ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░  ░░▒▒  ██████████████    ████████▓▓▓▓▓▓▓▓████████████████████████▓▓  ▒▒▒▒▒▒▒▒  ░░▒▒             ");
                    Console.WriteLine("            ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒  ██▒▒██████████  ▓▓▓▓▓▓▓▓██████████████████████████  ░░██████░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒             ");
                    Console.WriteLine("            ▒▒  ▒▒░░░░▒▒░░▒▒  ▒▒    ██▒▒░░░░░░████▓▓████████████████████████████████░░    ▒▒████▓▓▒▒▒▒░░▒▒▒▒▒▒▒▒             ");
                    Console.WriteLine("                ▒▒░░░░▒▒░░▒▒▒▒▒▒    ██▒▒░░  ░░░░████████▓▓▓▓▓▓████▓▓▓▓▓▓██  ████████        ██████░░▒▒░░  ▒▒  ▒▒             ");
                    Console.WriteLine("                ▒▒░░░░▒▒░░░░▒▒      ██▒▒░░  ██░░██████▓▓▓▓▓▓████████▓▓▓▓██      ████        ██████░░▒▒░░░░▒▒                 ");
                    Console.WriteLine("               ░░  ░░░░░░░░▒▒      ██▒▒▒▒░░████████▓▓▓▓██████▓▓▓▓▓▓██▓▓██                  ██████░░▒▒░░░░▒▒                  ");
                    Console.WriteLine("                ░░      ░░▒▒▒▒        ██▓▓▒▒░░██████▓▓██████████▓▓▓▓████████                ██████░░  ░░  ▒▒                 ");
                    Console.WriteLine("                ▒▒▒▒  ░░▒▒░░▒▒            ████████▓▓██▓▓██████▓▓▓▓▓▓▓▓▓▓████            ░░██████░░░░      ▒▒                 ");
                    Console.WriteLine("                  ░░    ░░▒▒▒▒                ██████▓▓██████████████▓▓▓▓▓▓██            ░░██████░░▒▒▒▒  ▒▒▒▒                 ");
                    Console.WriteLine("                 ▒▒▒▒    ▒▒▒▒▒▒              ████▓▓▓▓▓▓██████▓▓▓▓▓▓▓▓██▓▓██            ░░██████▒▒░░    ▒▒                    ");
                    Console.WriteLine("                    ▒▒▒▒░░░░▒▒▒▒            ████▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓██▓▓████          ░░██████▒▒    ▒▒▒▒                   ");
                    Console.WriteLine("                      ▒▒▒▒░░░░▒▒            ████▓▓██▓▓████████▓▓████████▓▓████          ░░██████░░░░▒▒▒▒                     ");
                    Console.WriteLine("                       ▒▒░░░░▒▒            ████████████▓▓▓▓▓▓▓▓██████▓▓██████          ░░██████░░▒▒▒▒                        ");
                    Console.WriteLine("                        ▒▒░░░░▒▒            ████▓▓████████▓▓▓▓▓▓▓▓████████▓▓██        ░░▓▓████▒▒░░▒▒                         ");
                    Console.WriteLine("                         ▒▒▒▒▒▒          ▓▓████████████▓▓▓▓▓▓▓▓██████████▓▓██▓▓      ░░██████░░░░▒▒                          ");
                    Console.WriteLine("                            ▒▒▒▒░░        ████▓▓██▓▓████████████████████▓▓▓▓████      ░░██▓▓██▒▒░░                           ");
                    Console.WriteLine("                            ▒▒▒▒▒▒        ██████▓▓██████████████▓▓▓▓██▓▓▓▓▓▓▓▓██      ░░██████▒▒                             ");
                    Console.WriteLine("                              ▒▒▒▒      ████████▓▓▓▓▓▓████████▓▓▓▓██▓▓▓▓▓▓████████    ░░██████▒▒                             ");
                    Console.WriteLine("                                ▒▒      ██████████▓▓▓▓▓▓████▓▓▓▓▓▓▓▓██████████████      ████▓▓                               ");
                    Console.WriteLine("                                ▒▒    ██████████████████████████████████████████████  ░░████▓▓                               ");

                    Console.ReadKey();
                }


            }
            return terminado;
        }

    }
}
