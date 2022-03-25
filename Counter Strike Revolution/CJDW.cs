﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

// Change this to match your program's normal namespace
class CJDW
{
    public static string GetFile(string Path, string Section, string Key)
    {

        IEnumerable<string> results = File.ReadAllLines(Path).Where(l => l.StartsWith(Section + " " + Key));
        return results.ToArray()[0].Split(' ')[2];
    }

    public static void ChangeFile(string Path, string Section, string Key, string Value)
    {
        var index = Array.FindIndex(File.ReadAllLines(Path).ToArray(), row => row.StartsWith(Section + " " + Key));
        string[] arrLine = File.ReadAllLines(Path);
        arrLine[index] = Section + " " + Key + " " + Value;
        File.WriteAllLines(Path, arrLine);
    }
    public static void SetFile(string Path, string Section, string Key, string Value)
    {
        File.WriteAllText(Path, File.ReadAllText(Path) + "\r\n" + Section + " " + Key + " " + Value);
    }

    public static string GetFileNoSection(string Path, string Key)
    {
        string a = Key;
        IEnumerable<string> results = File.ReadAllLines(Path).Where(l => l.StartsWith(a));
        return results.ToArray()[0].Split(' ')[1];
    }

    public static void ChangeFileNoSection(string Path, string Key, string Value)
    {
        if (!File.Exists(Path))
        {
            File.Create(Path).Close();
        }

        var index = Array.FindIndex(File.ReadAllLines(Path).ToArray(), row => row.StartsWith(Key));
        string[] arrLine = File.ReadAllLines(Path);
        arrLine[index] = Key + " " + Value;
        File.WriteAllLines(Path, arrLine);
    }
    public static void SetFileNoSection(string Path, string Key, string Value)
    {
        if (!File.Exists(Path))
        {
            File.Create(Path).Close();
        }

        File.WriteAllText(Path, File.ReadAllText(Path) + "\r\n" + Key + " " + Value);


    }
    public static void Rescale(Form form, bool stretch)
    {
        float screenHeight = (float)Screen.PrimaryScreen.Bounds.Height;
        float currentHeight = (float)form.Height;
        float screenWidth = (float)Screen.PrimaryScreen.Bounds.Width;
        float currentWidth = (float)form.Width;
        float ratio = screenHeight / currentHeight;
        float ratioW = screenWidth / currentWidth;
        form.Top = 0;
        form.Height = (int)screenHeight;
        if (stretch)
        {
            form.Width = (int)screenWidth;
            form.Left = 0;
        }
        else
        {
            form.Width = (int)(ratio * currentWidth);
            form.Left = (Screen.PrimaryScreen.Bounds.Width - form.Width) / 2;
        }
        foreach (Control i in form.Controls)
        {
            i.Height = (int)(ratio * i.Height);
            i.Top = (int)(ratio * i.Top);

            if (stretch)
            {
                i.Left = (int)(ratioW * i.Left);
                i.Width = (int)(ratioW * i.Width);
            }
            else
                i.Left = (int)(ratio * i.Left);
            i.Width = (int)(ratio * i.Width);
            i.Font = new Font(i.Font.FontFamily.Name, ratio * i.Font.Size);
        }
    }
}