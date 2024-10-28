
using System;

public class Animation : Activity
{


        // for (int i = 10; i > 0; i--)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b\b \b\b");
           
        // }
        
      public string DisplayStartMessage()
      {  
        Console.Write("\b");
        
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        
        

        //  foreach (string s in animations)
        //  {
        //      Console.Write(s);
        //      Thread.Sleep(1000);
        //      Console.Write("\b \b");

        //  }

         DateTime startTime = DateTime.Now;
         
         DateTime endTime = startTime.AddSeconds(5);

         int i = 0;
         Console.Write("Loding");
         while (DateTime.Now < endTime)
         {
             string s = animations[i];
         }
    public Animation(string _name, string _description, int _duration) : base(_name, _description, _duration)
    {
    }

    // Console .Write(s);
    //          Thread.Sleep(1000);
    //          Console.Write("\b \b");

        //      i++;
        //      if (i >= animations.Count)
        //      {
        //          i = 0;
        //      }
        //  }
        //  Console.WriteLine(" \b\b \b\b \b\b \b\b \b\b \b\b ");
        //  Console.WriteLine("done");
      
         public string GetHomeworkList()
        {
            return $"Section {0} Problems {0}";
        }
      }  
        

}