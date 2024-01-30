using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin:Treasure
	{
		public int Value; 
		public Coin(string description, int score, int value) : base(description,score)
		{
            this.Value = value;
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
			//UpdateTotalValue();
			UpdateTotalScore(); 
		}

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }

		public override void Display()
		{
            Console.WriteLine("Coin " + Description + " is displayed");
        }

		public void UpdateTotalValue()
		{
			//TotalValue += Value;
			TotalScore += Value; 
			Console.WriteLine("Total value is updated to: " + TotalValue); 
		}

    }
}

