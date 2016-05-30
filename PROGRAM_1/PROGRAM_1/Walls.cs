﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM_1
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // Отрисовка рамочки
            Horisontal upLine = new Horisontal(0, mapWidth - 2, 0, '+');
            Horisontal downLine = new Horisontal(0, mapWidth - 2, mapHeight - 1, '+');
            Vertical leftLine = new Vertical(0, mapHeight - 1, 0, '+');
            Vertical rightLine = new Vertical(0, mapHeight - 1, mapWidth - 2, '+');

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }
  
 	    	internal bool IsHit(Figure figure)
     		{
 			    foreach(var wall in wallList)
 		    	{
 	    			if(wall.IsHit(figure))
    				{
 					    return true;
 				    }
 			    }
 			    return false;
 		    }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }


        }

    }
}
