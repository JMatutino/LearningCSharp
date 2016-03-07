using System;
namespace ParrotApp {
  class Parrot {
    private string wordHear;
    
    public bool HearWord() {
      Console.WriteLine("Braawwwkk what did you say?");
      wordHear = Console.ReadLine();
      if (wordHear != "shutup") {
        return true;
      }
      return false;
    }
    
    public void SayWord() {
      Console.WriteLine("Braawwkk {0}", wordHear);
    }
  }
  
  class MeetParrot {
    static void Main(string[] args) {
      Parrot p = new Parrot();
      Console.WriteLine("Youre walking and you encounter a parrot in a tree.");
      Console.WriteLine("Tell it 'shutup' to leave...");
      while(p.HearWord()) {
        p.SayWord();
        Console.WriteLine("--------------------");
      }
      Console.WriteLine("Braawwk bye bye!!");
    }
  }
}