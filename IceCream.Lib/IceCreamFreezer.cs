using System.Collections.Generic;

namespace IceCream.Lib
{
	public class IceCreamFreezer : IProvideIceCream, IStoreIceCream
	{
		private readonly List<IceCreamProduct> _iceCreams;

		/// <summary>
		/// Constructs a new Ice Cream Freezer
		/// </summary>
		public IceCreamFreezer()
		{
			_iceCreams = new List<IceCreamProduct>();
		}

		/// <summary>
		/// Returns the contents of the Ice Cream Freezer.
		/// </summary>
		/// <returns><see cref="IList{IceCreamProduct}"/> of Ice Cream.</returns>
		public IList<IceCreamProduct> Contents()
		{
			return _iceCreams;
		}

		/// <summary>
		/// Returns an Ice Cream From the Freezer.
		/// </summary>
		/// <returns><see cref="IceCreamProduct"/> from the Freezer.</returns>
		public IceCreamProduct ProvideIceCream()
		{
			return new IceCreamProduct();
		}

		public void AddIceCream(IceCreamProduct iceCreamProduct)
		{
			_iceCreams.Add(iceCreamProduct);
		}

	}
}
