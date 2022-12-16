using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

class renderManager
{
    private string[] characterSet = { "|", ".", "-", "*", "#" };


    public void RenderObjectBarHorizontal(int length, int writeType = 1)
    {
        var current = new StringBuilder();

        for (int i = 0; i > length; i++)
        {
            current.Append(characterSet[writeType]);
        }

        Console.Clear();
        Console.WriteLine(current);
    }

    public void RenderObjectBarVertical(int length, int writeType, int line = 1)
    {
        var current = new StringBuilder();

        for (int i = 0; i > length; i++)
        {
            current.Append(characterSet[writeType]);
        }
        Console.Clear();
        Console.Write(current);

    }

}