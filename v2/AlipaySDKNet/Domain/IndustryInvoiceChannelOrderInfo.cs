using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceChannelOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceChannelOrderInfo : AopObject
    {
        /// <summary>
        /// 渠道订单金额，总位数20位，最多16位整数，最多2位小数，单位：元
        /// </summary>
        [XmlElement("channel_order_amount")]
        public string ChannelOrderAmount { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [XmlElement("channel_order_no")]
        public string ChannelOrderNo { get; set; }
    }
}
