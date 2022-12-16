using System;

class renderManager 
{
    private char[] characterSet = {"|", ".", "-","*","#"};
    public void RenderObjectBar(int length, int writeType = 1)
    {
            string current;

            for(int i = 0; i > length; i++)
            {
               current = current + characterSet[writeType];
               Console.Clear();
               Console.WriteLine(current);
            }    
    }
}