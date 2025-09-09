using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommercialInsuranceParams Data Structure.
    /// </summary>
    [Serializable]
    public class CommercialInsuranceParams : AopObject
    {
        /// <summary>
        /// 投保渠道编码，由平台方分配
        /// </summary>
        [XmlElement("insure_channel_code")]
        public string InsureChannelCode { get; set; }

        /// <summary>
        /// 投保产品名称
        /// </summary>
        [XmlElement("insure_product_name")]
        public string InsureProductName { get; set; }

        /// <summary>
        /// 支付商户号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 支付终端号
        /// </summary>
        [XmlElement("terminal_no")]
        public string TerminalNo { get; set; }
    }
}
