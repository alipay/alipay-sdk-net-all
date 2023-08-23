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
        /// 支付宝账号，本次场景是和蚂蚁保签约的平台账号
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 操作关联的支付宝openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 证件名称，本次场景是和蚂蚁保签约的平台名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件名称，本次场景是和蚂蚁保签约的平台证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件名称，本次场景是和蚂蚁保签约的平台证件类型
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
