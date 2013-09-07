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
			Init();
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

		/// <summary>
		/// Add some default values to the freezer
		/// </summary>
		private void Init()
		{
			_iceCreams.Add(new IceCreamProduct{Name="Default Buddy", Cost ="1.50", Flavor ="Unflavored"});
			_iceCreams.Add(new IceCreamProduct{Name="Sad Panda Bars", Cost ="1.50", Flavor ="Trail of Tears"});
		}
	}
}
