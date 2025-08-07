using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class RecursionSamples
    {
        /*
        Recursion calls a function until the base case is met 
        When the base case is met the function returns 
        Resolving each call as it unwinds.

        For each recurse there is a pre, recures and post step and these are important
        when it comes to pathing.

        */

        public int foo(int n)
        {
            // Base case
            if (n == 1)
                return 1;

            // Recurse
            return n + foo(n - 1);
        }

        public static Stack<Point> MazeSolver(string[] maze, char wall, Point start, Point end)
        {
            bool[,] seen = new bool[maze.Length, maze[0].Length];
            Stack<Point> path = new Stack<Point>();

            for(int i = 0; i < maze.Length; i++)
            {
                for(int j = 0; j < maze[i].Length; j++)
                {
                    seen[i, j] = false; 
                }
            }

            Walk(maze, wall, start, end, seen, path);

            // list of points from start to end
            return path;
        }

        private static int[][] _directions = new int[4][];

        // right, up, left, down
        //public static int[][] Directions { get; set; } = [[1, 0],[0, 1],[-1, 0], [0, -1]];

        public static Point[] Directions { get; set; } = [
            new Point(0, 1),
            new Point(1, 0),
            new Point(0, -1),
            new Point(-1, 0)];


        public static bool Walk(string[] maze, char wall, Point currentPoint, Point end, bool[,] seen, Stack<Point> path)
        {
            // Base cases
            // 1. Off the map
            if( currentPoint.X < 0 || currentPoint.X >= maze[0].Length ||
                currentPoint.Y < 0 || currentPoint.Y >= maze.Length){
                return false;
            }

            // 2. on a wall
            if (maze[currentPoint.Y][currentPoint.X] == wall)
            {
                return false;
            }

            // 3. Are we at the end
            if (currentPoint.X == end.X && currentPoint.Y == end.Y)
            {
                path.push(end);
                return true;
            }

            if (seen[currentPoint.Y, currentPoint.X])
            {
                return false;
            }

            // Recurse
            // Pre
            seen[currentPoint.Y, currentPoint.X] = true;
            path.push(currentPoint);
            // Recurse
            for(int i = 0; i < Directions.Length; i++)
            {
                var currentDirection = Directions[i];
                if(Walk(
                    maze,
                    wall,
                    new Point(
                        currentPoint.X + currentDirection.X,
                        currentPoint.Y + currentDirection.Y),
                    end,
                    seen,
                    path))
                {
                    return true;
                }
            }

            // Post
            path.pop();

            return false;
        }
    }
}
