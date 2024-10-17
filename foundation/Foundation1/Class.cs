using System;
public class Comment
{
    private List<Comment> _comments = new List<Comment>();
    
    public string Scripture()  
    {
        string _text = "go forth and oreach my words ";

        string [] words = _text.Split(" ");
        return words[5];
    }
        
public void Display(string words)

{
    
    Console.Write($"{words} -");
        // foreach (string word in words)
        // {
        //     _comments.Add(new Comment());

        //     Console.Write($"{word} -");
               
             
        // }
}
}