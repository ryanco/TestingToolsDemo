using System;
using System.Collections.Generic;


namespace TestingTools
{
    public class IceCreamFreezer : IProvideIceCream, IStoreIceCream
    {
        private readonly List<IceCream> _iceCreams; 
 
        public IceCreamFreezer()
        {
            _iceCreams = new List<IceCream>();
        }

        public IList<IceCream> Contents()
        {
            return _iceCreams;
        }

        public IceCream ProvideIceCream()
        {
            return new IceCream();
        }

        public void AddIceCream(IceCream iceCream)
        {
            _iceCreams.Add(iceCream);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _iceCreams.ToString();
        }
    }
}
