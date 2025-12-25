using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseInvoiceapplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseInvoiceapplyQueryModel : AopObject
    {
        /// <summary>
        /// 虚拟运单编码
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 支付宝企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

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
