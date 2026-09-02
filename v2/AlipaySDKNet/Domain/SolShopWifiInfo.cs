using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolShopWifiInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SolShopWifiInfo : AopObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("wifi_list")]
        [XmlArrayItem("sol_wifi_info")]
        public List<SolWifiInfo> WifiList { get; set; }
    }
}
