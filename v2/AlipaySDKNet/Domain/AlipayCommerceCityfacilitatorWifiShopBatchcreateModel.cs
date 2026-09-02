using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorWifiShopBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorWifiShopBatchcreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_info_list")]
        [XmlArrayItem("sol_wifi_shop_info")]
        public List<SolWifiShopInfo> ShopInfoList { get; set; }
    }
}
