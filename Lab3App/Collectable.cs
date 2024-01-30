using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Collectable : CollectionBoard, Displayable
	{
		public String Description;

		private CollectionBoard board; 

		public Collectable(String description)
		{
			this.Description = description; 
		}

		public CollectionBoard Board
		{
			get
			{
				return board; 
			}
			set
			{
				this.board = value;
			}
		}


		public abstract void Display(); 

		public virtual void AddMe(List<Collectable> list)
		{
			list.Add(this); 
		}

	}
}

