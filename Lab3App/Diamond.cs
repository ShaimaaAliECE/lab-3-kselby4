using System;
namespace Lab3App
{
	public class Diamond:Treasure
	{
		public Diamond(string description, int score) : base(description,score)
		{
            Console.WriteLine(base.Description + " Collected, Congrats!!!!");
            UpdateTotalScore(); 
        }

        public override void Display()
        {
            Console.WriteLine("Diamond" + this.Description + " is displayed");
        }
    }
}

