using System;
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
    public static string GetFileNoSection(string Path, string Key)
    {
        string a = Key;
        IEnumerable<string> results = File.ReadAllLines(Path).Where(l => l.StartsWith(a));
        return results.ToArray()[0].Split(' ')[1];
    }
    public static void ChangeFile(string Path, string Section, string Key, string Value)
    {
        var index = Array.FindIndex(File.ReadAllLines(Path).ToArray(), row => row.StartsWith(Section + " " + Key));
        string[] arrLine = File.ReadAllLines(Path);
        arrLine[index] = Section + " " + Key + " " + Value;
        File.WriteAllLines(Path, arrLine);
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
    public static void SetFile(string Path, string Section, string Key, string Value)
    {
        File.WriteAllText(Path, File.ReadAllText(Path) + "\r\n" + Section + " " + Key + " " + Value);
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
    public static Bitmap CropImage(Bitmap source, Rectangle section)
    {
        var bitmap = new Bitmap(section.Width, section.Height);
        using (var g = Graphics.FromImage(bitmap))
        {
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
            return bitmap;
        }
    }
    public static Bitmap GrayScaleFilter(Bitmap image)
    {
        Bitmap grayScale = new Bitmap(image.Width, image.Height);

        for (Int32 y = 0; y < grayScale.Height; y++)
            for (Int32 x = 0; x < grayScale.Width; x++)
            {
                System.Drawing.Color c = image.GetPixel(x, y);

                Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                grayScale.SetPixel(x, y, System.Drawing.Color.FromArgb(gs, gs, gs));
            }
        return grayScale;
    }
    public static string GetAmxxConfig(string Path, string Section, string Value, string GetValueBySection)
    {
        string[] line = File.ReadLines(Path).Skip(GetLineNumber(Path, Value, Section) -1).Take(1).First().Split('[');

        IEnumerable<string> results = line.Where(l => l.StartsWith(GetValueBySection + "]"));
        return results.ToArray()[0].Split(']')[1];

    }
    public static string GetAmxxConfigNoCommand(string Path, string Section, int line)
    {

        string[] line2 = File.ReadLines(Path).Skip(line).Take(1).First().Split('[');

        IEnumerable<string> results = line2.Where(l => l.StartsWith(Section + "]"));
        return results.ToArray()[0].Split(']')[1];

    }
    public static int GetLineNumber(string Path, string Value, string Section)
    {
        Value = "["+ Section + "]" + Value + "[";
        int lineNum = 0;
        string line;
        System.IO.StreamReader file = new System.IO.StreamReader(Path);
        while ((line = file.ReadLine()) != null)
        {
            lineNum++;
            if (line.Contains(Value))
            {
                return lineNum;
            }
        }
        file.Close();
        return -1;
    }
  
}
