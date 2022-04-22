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

		public Room(string b)
		{
			beskrivning = b;
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
	}
}
