using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorWifiModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorWifiModifyModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_wifi_list")]
        [XmlArrayItem("sol_shop_wifi_info")]
        public List<SolShopWifiInfo> ShopWifiList { get; set; }
    }
}
