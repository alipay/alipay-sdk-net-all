using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KnCertSendOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KnCertSendOrderDetail : AopObject
    {
        /// <summary>
        /// 在此凭证单据下，用户还剩余的有效凭证点数
        /// </summary>
        [XmlElement("cert_remain_point")]
        public long CertRemainPoint { get; set; }

        /// <summary>
        /// 营销平台凭证模板ID(即营销凭证批次号)，可能是数字和字母的组合
        /// </summary>
        [XmlElement("cert_template_id")]
        public string CertTemplateId { get; set; }

        /// <summary>
        /// 用户此凭证单据产生的时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 用户此凭证单据下的凭证的失效时间
        /// </summary>
        [XmlElement("gmt_expire")]
        public string GmtExpire { get; set; }

        /// <summary>
        /// 产生此用户凭证时的凭证单据号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }
    }
}
