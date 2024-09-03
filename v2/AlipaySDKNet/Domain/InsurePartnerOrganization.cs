using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsurePartnerOrganization Data Structure.
    /// </summary>
    [Serializable]
    public class InsurePartnerOrganization : AopObject
    {
        /// <summary>
        /// 账号主体类型，默认ALIPAY_USER_ID
        /// </summary>
        [XmlElement("alipay_account_type")]
        public string AlipayAccountType { get; set; }

        /// <summary>
        /// 参与方唯一标识，当alipay_account_type为ALIPAY_USER_ID是表示支付宝2088uid, 当alipay_account_type为ALIPAY_LOGON_ID时表示支付宝登录号
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 账号主体id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 证件名称，本次场景和投保企业信息保持一致
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号，本次场景和投保企业信息保持一致
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，本次场景和投保企业信息保持一致
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 如果存在第二合作商，则传入合作商id
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }
    }
}
