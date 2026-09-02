using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceChannelInfo : AopObject
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 渠道订单信息列表
        /// </summary>
        [XmlArray("channel_order_info_list")]
        [XmlArrayItem("industry_invoice_channel_order_info")]
        public List<IndustryInvoiceChannelOrderInfo> ChannelOrderInfoList { get; set; }

        /// <summary>
        /// 外部渠道商户ID
        /// </summary>
        [XmlElement("out_channel_merchant_id")]
        public string OutChannelMerchantId { get; set; }
    }
}
