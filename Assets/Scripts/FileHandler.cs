using System;
using System.IO;
using UnityEngine;

public class FileHandler
{
    private string _path = @"E:\UnityHub\Projects\Sokoban\Map1.txt";
    public char[,] Read()
    {
        try
        {
            StreamReader sr = new StreamReader(this._path);
            string line = sr.ReadLine();
            int size = line.Length;
            char[,] map = new char[size, size];
            int ln = 0;
            while (line != null)
            {
                for (int i = 0; i < size; i++)
                {
                    map[i, ln] = line[i];
                }
                ln++;
                line = sr.ReadLine();
            }
            return map;
        }
        catch (Exception e)
        {
            Debug.LogError(e);
            return null;
        }
    }
}
