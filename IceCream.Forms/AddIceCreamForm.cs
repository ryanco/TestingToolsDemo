using System;
using System.Windows.Forms;
using IceCream.Lib;

namespace IceCream.Forms
{
	public partial class AddIceCreamForm : Form
	{
		readonly IceCreamFreezer _freezer = new IceCreamFreezer();
		public AddIceCreamForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var iceCream = new Lib.IceCreamProduct
				{
					Name = nameBox.Text,
					Cost = costBox.Text,
					Flavor = flavorBox.Text
				};
			AddIceCreamToFreezer(iceCream);
			ClearInput();
		}
		/// <summary>
		/// Add Ice Cream to the Storage unit.
		/// </summary>
		/// <param name="iceCreamProduct"></param>
		public void AddIceCreamToFreezer(Lib.IceCreamProduct iceCreamProduct)
		{
			_freezer.AddIceCream(iceCreamProduct);
			ResetListBox();
		}
		/// <summary>
		/// Resets the contents of the List Box form the model.
		/// </summary>
		public void ResetListBox()
		{
			iceCreamListBox.Items.Clear();
			foreach (var item in _freezer.Contents())
			{
				iceCreamListBox.Items.Add(item);
			}
		}
		/// <summary>
		/// Clears the input fields.
		/// </summary>
		public void ClearInput()
		{
			nameBox.Clear();
			costBox.Clear();
			flavorBox.Clear();
		}
	}
}
