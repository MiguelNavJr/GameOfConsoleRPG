﻿using GameOfConsoleRPG.SonClass.enemy;
using GameOfConsoleRPG.SonClass.hero;
using GameOfConsoleRPG.SonClass.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameOfConsoleRPG.MotherClass
{
    public class Heros
    {
        //public
        public string Name;
        public int Hp;
        public int Mana;
        public int Lvl;
        public int X;
        public int Y;
        public int velocx;
        public int velocy;

        //private
        private string _name;
        private int _hp;
        private int _mana;
        private string _atk1;
        private string _atk2;
        private string _atk3;
        private string _atk4;
        private string _special;
        private int _exp;

        //protected
        protected int xMapa = 10;
        protected int yMapa = 2;
        protected string[] mapa =
{
        "############################################     #",
        "#          #                            ##       #",
        "#                         ##                     #",
        "#          #                                     #",
        "#          #                                     #",
        "#          #                                     #",
        "#          #######################################",
        };


        public Heros(int lvl, int x, int y)
        {
  
            Lvl = lvl;
            X = x;
            Y = y;
        }

        public string Nombre
        {
            get { return _name; }

            set
            {
                _name = value;
            }
        }

        public int Highpoints
        {
            get { return _hp; }

            set
            {
                _hp = value;
            }
        }

        public int ElMana
        {
            get { return _mana; }

            set
            {
                _mana = value;
            }
        }

        public string Ataque1 {

            get { return _atk1; }

            set
            {
                _atk1 = value;
                TipoAtaque1();
            }

        }

        public string Ataque2
        {

            get { return _atk2; }

            set
            {
                _atk2 = value;
                TipoAtaque2();
            }

        }

        public string Ataque3
        {

            get { return _atk3; }

            set
            {
                _atk3 = value;
                TipoAtaque3();
            }

        }

        public string Ataque4
        {

            get { return _atk4; }

            set
            {
                _atk4 = value;
                
                TipoAtaque4();
            }

        }

        public string Especialista
        {

            get { return _special; }

            set
            {
                _special = value;
                AccesoAtaqueEspecialista();
            }

        }

        public int Experiencia {
            get { return _exp; }

            set
            {
                _exp = value;

                if (_exp > 0)
                {
                    ExperienciaGanada();
                }

            }
        }

        public void ComprobarEntradayUsuario(Mage merlin)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if ((tecla.Key == ConsoleKey.LeftArrow)
                        && (EsPosibleMover(merlin.X - 1, merlin.Y)))
                    merlin.X--;

                if ((tecla.Key == ConsoleKey.RightArrow)
                        && (EsPosibleMover(merlin.X + 1, merlin.Y)))
                    merlin.X++;

                if ((tecla.Key == ConsoleKey.UpArrow)
                        && (EsPosibleMover(merlin.X, merlin.Y - 1)))
                    merlin.Y--;

                if ((tecla.Key == ConsoleKey.DownArrow)
                        && (EsPosibleMover(merlin.X, merlin.Y + 1)))
                    merlin.Y++;
            }

        }

        public void ComprobarEntradayUsuarioajax(Warrior ajax)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if ((tecla.Key == ConsoleKey.LeftArrow)
                        && (EsPosibleMover(ajax.X - 1, ajax.Y)))
                    ajax.X--;

                if ((tecla.Key == ConsoleKey.RightArrow)
                        && (EsPosibleMover(ajax.X + 1, ajax.Y)))
                    ajax.X++;

                if ((tecla.Key == ConsoleKey.UpArrow)
                        && (EsPosibleMover(ajax.X, ajax.Y - 1)))
                    ajax.Y--;

                if ((tecla.Key == ConsoleKey.DownArrow)
                        && (EsPosibleMover(ajax.X, ajax.Y + 1)))
                    ajax.Y++;
            }

        }

        public void ComprobarEntradayUsuariolegolas(Archer legolas)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if ((tecla.Key == ConsoleKey.LeftArrow)
                        && (EsPosibleMover(legolas.X - 1, legolas.Y)))
                    legolas.X--;

                if ((tecla.Key == ConsoleKey.RightArrow)
                        && (EsPosibleMover(legolas.X + 1, legolas.Y)))
                    legolas.X++;

                if ((tecla.Key == ConsoleKey.UpArrow)
                        && (EsPosibleMover(legolas.X, legolas.Y - 1)))
                    legolas.Y--;

                if ((tecla.Key == ConsoleKey.DownArrow)
                        && (EsPosibleMover(legolas.X, legolas.Y + 1)))
                    legolas.Y++;
            }

        }

        public bool EsPosibleMover(int x, int y)
        {

            x -= xMapa;
            y -= yMapa;

            try
            {
                if (mapa[y][x] == '#')
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public void PausaHastaFinDeFotograma()
        {
            Thread.Sleep(100);
        }

        public void DibujarCalabozo(Mage merlin, EnemyPeon[] peon, ObjectBomb[] items, int punto)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < mapa.Length; i++)
            {
                Console.SetCursorPosition(xMapa, yMapa + i);
                Console.Write(mapa[i]);
            }

            Console.ForegroundColor = merlin.Color;
            Console.SetCursorPosition(merlin.X, merlin.Y);
            Console.Write(merlin.Simbolo);

            for (int i = 0; i < peon.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(peon[i].x, peon[i].y);
                Console.Write(peon[i].Simbolo);
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Visible)
                {

                    Console.ForegroundColor = items[i].Color;
                    Console.SetCursorPosition(items[i].X, items[i].Y);
                    Console.Write(items[i].Simbolo);
                }
            }

            Console.SetCursorPosition(1, 1);
            Console.Write("Puntos: " + punto);
        }

        public void DibujarCalabozoajax(Warrior ajax, EnemyPeon[] peon, ObjectBomb[] items, int punto)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < mapa.Length; i++)
            {
                Console.SetCursorPosition(xMapa, yMapa + i);
                Console.Write(mapa[i]);
            }

            Console.ForegroundColor = ajax.Color;
            Console.SetCursorPosition(ajax.X, ajax.Y);
            Console.Write(ajax.Simbolo);

            for (int i = 0; i < peon.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(peon[i].x, peon[i].y);
                Console.Write(peon[i].Simbolo);
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Visible)
                {

                    Console.ForegroundColor = items[i].Color;
                    Console.SetCursorPosition(items[i].X, items[i].Y);
                    Console.Write(items[i].Simbolo);
                }
            }

            Console.SetCursorPosition(1, 1);
            Console.Write("Puntos: " + punto);
        }

        public void DibujarCalabozoLegolas(Archer legolas, EnemyPeon[] peon, ObjectBomb[] items, int punto)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < mapa.Length; i++)
            {
                Console.SetCursorPosition(xMapa, yMapa + i);
                Console.Write(mapa[i]);
            }

            Console.ForegroundColor = legolas.Color;
            Console.SetCursorPosition(legolas.X, legolas.Y);
            Console.Write(legolas.Simbolo);

            for (int i = 0; i < peon.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(peon[i].x, peon[i].y);
                Console.Write(peon[i].Simbolo);
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Visible)
                {

                    Console.ForegroundColor = items[i].Color;
                    Console.SetCursorPosition(items[i].X, items[i].Y);
                    Console.Write(items[i].Simbolo);
                }
            }

            Console.SetCursorPosition(1, 1);
            Console.Write("Puntos: " + punto);
        }

        private void ExperienciaGanada()
        {
            if(Lvl == 5) {
                _exp = 500;
             }
            else if( Lvl >= 15 )
            {
                _exp = 300;
            }
            else if (Lvl >= 25)
            {
                _exp = 100;
            }
        }

        private void AccesoAtaqueEspecialista()
        {
            if (Lvl == 5)
            {
                Console.WriteLine("Aun no pueds acceder a este ataque");
                    }
            else if (Lvl >= 15)
            {
                Console.WriteLine("Aun no pueds acceder a este ataque");
            }
            else if (Lvl >= 25)
            {
                Console.WriteLine("Tu ataque especialista es QuadForce");
                _special = "QuadForce";
            }

        }

        private void TipoAtaque1()
        {
            if (Lvl == 5)
            {
                _atk1 = "Ember";
            }
            else if (Lvl >= 15)
            {
                _atk1 = "FireBall";
            }
            else if (Lvl >= 25)
            {

                _atk1 = "Incinerate";

            }

        }

        protected void TipoAtaque2()
        {
            if (Lvl == 5)
            {
                _atk2 = "WaterGun";
            }
            else if (Lvl >= 15)
            {
                _atk2 = "Surf";
            }
            else if (Lvl >= 25)
            {

                _atk2 = "Tsunami";

            }

        }

        protected void TipoAtaque3()
        {
            if (Lvl == 5)
            {
                _atk3 = "False Swipe";
            }
            else if (Lvl >= 15)
            {
                _atk3 = "Energy Ball";
            }
            else if (Lvl >= 25)
            {

                _atk3 = "Frenzy Plant";

            }

        }

        protected void TipoAtaque4()
        {
            if (Lvl == 5)
            {
                _atk4 = "Spark";
             }
            else if (Lvl >= 15)
            {
                _atk4 = "thunderbolt";
            }
            else if (Lvl >= 25)
            {

                _atk4 = "Thunder";

            }
        }

    }
}
