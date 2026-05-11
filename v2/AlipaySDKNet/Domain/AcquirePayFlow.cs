using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AcquirePayFlow Data Structure.
    /// </summary>
    [Serializable]
    public class AcquirePayFlow : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("acquire_pay_flow_shop_info")]
        public List<AcquirePayFlowShopInfo> ShopList { get; set; }

        /// <summary>
        /// 店铺数量
        /// </summary>
        [XmlElement("shop_num")]
        public string ShopNum { get; set; }
    }
}
