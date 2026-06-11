using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCommercialOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCommercialOrderCloseModel : AopObject
    {
        /// <summary>
        /// 关闭订单的具体原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 需要关闭的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
