using System.Collections.Generic;

namespace TestingTools
{
	public class IceCreamFreezer : IProvideIceCream, IStoreIceCream
	{
		private readonly List<IceCream> _iceCreams;

		/// <summary>
		/// Constructs a new Ice Cream Freezer
		/// </summary>
		public IceCreamFreezer()
		{
			_iceCreams = new List<IceCream>();
		}

		/// <summary>
		/// Returns the contents of the Ice Cream Freezer.
		/// </summary>
		/// <returns><see cref="IList{IceCream}"/> of Ice Cream.</returns>
		public IList<IceCream> Contents()
		{
			return _iceCreams;
		}

		/// <summary>
		/// Returns an Ice Cream From the Freezer.
		/// </summary>
		/// <returns><see cref="IceCream"/> from the Freezer.</returns>
		public IceCream ProvideIceCream()
		{
			return new IceCream();
		}

		public void AddIceCream(IceCream iceCream)
		{
			_iceCreams.Add(iceCream);
		}

	}
}
