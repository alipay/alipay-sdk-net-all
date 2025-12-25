using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseInvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseInvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 虚拟运单编码,一次性最多开十张
        /// </summary>
        [XmlArray("apply_ids")]
        [XmlArrayItem("string")]
        public List<string> ApplyIds { get; set; }

        /// <summary>
        /// 支付宝企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 发票接收邮箱
        /// </summary>
        [XmlElement("invoice_mail")]
        public string InvoiceMail { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
