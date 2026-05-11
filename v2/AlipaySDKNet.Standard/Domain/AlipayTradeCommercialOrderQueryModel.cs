using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCommercialOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCommercialOrderQueryModel : AopObject
    {
        /// <summary>
        /// 订单号，通过订单创建接口获取
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
