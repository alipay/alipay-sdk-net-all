using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderUpgradeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderUpgradeModel : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 需要授权的代操作产品列表，传入code集合，一次最多10个，如果授权时三方应用关联的产品有变化也会同步重新授权
        /// </summary>
        [XmlArray("product_codes")]
        [XmlArrayItem("string")]
        public List<string> ProductCodes { get; set; }
    }
}
