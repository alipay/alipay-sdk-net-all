using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPartnerOrganization Data Structure.
    /// </summary>
    [Serializable]
    public class InsPartnerOrganization : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 合作商id
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }
    }
}
