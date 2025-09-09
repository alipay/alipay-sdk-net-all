using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationMallhomePayresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationMallhomePayresultSyncModel : AopObject
    {
        /// <summary>
        /// 28码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商家外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 已支付完成的支付方式
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }
    }
}
