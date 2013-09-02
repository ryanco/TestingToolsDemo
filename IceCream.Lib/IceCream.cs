

namespace IceCream.Lib
{
	/// <summary>
	/// Ice Cream class for testing.
	/// </summary>
	public class IceCream
	{
		public string Name { get; set; }
		public string Flavor { get; set; }
		public string Cost { get; set; }


		/// <summary>
		/// Returns the string representation of Ice Cream.
		/// </summary>
		/// <returns>The string representation of Ice Cream.</returns>
		public override string ToString()
		{
			return "Name: "+Name+" Flavor: "+Flavor+" Cost: "+Cost;
		}

	}
}
