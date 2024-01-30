using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Treasure:Collectable
	{
		public int Score; 
		public Treasure(string description, int score) :base(description)
		{
			this.Score = score; 
		}

        public virtual void UpdateTotalScore()
		{
			TotalScore += Score;
            Console.WriteLine("Total score is updated to: " + TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }


    }
}

