using System;

namespace WpfAppÄventyrsspel
{
	public class Room
	{
		private string beskrivning;
		private Room norr;
		private Room syd;
		private Room öst;
		private Room väst;
		private Item myItem;
		private Boolean norrLåst;


		public Room(string b)
		{
			norrLåst = true;
			beskrivning = b;
		}

		public Boolean NorrLåst
        {
			get
            {
				return norrLåst;
            }
        }

		public Item MyItem
        {
			get
            {
				return myItem;
            }

			set
            {
				myItem = value;
            }
        }


		public Room Norr
		{
			get
			{
				return norr;
			}

			set
			{
				norr = value;

			}

		}


		public Room Syd
		{
			get
			{
				return syd;
			}

			set
			{
				syd = value;

			}
		}


		public Room Öst
		{
			get
			{
				return öst;
			}

			set
			{
				öst = value;

			}
		}


		public Room Väst
		{
			get
			{
				return väst;
			}

			set
			{
				väst = value;

			}
		}

		public string GetBeskrivning()
        {
			if (myItem == null)
            {
				return beskrivning;
			}

			else
            {
				return beskrivning + myItem.Beskrivning;

			}
			        
        }
	}
}
