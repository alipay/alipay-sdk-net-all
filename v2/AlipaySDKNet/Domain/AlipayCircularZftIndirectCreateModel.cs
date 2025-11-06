using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCircularZftIndirectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCircularZftIndirectCreateModel : AopObject
    {
        /// <summary>
        /// 签约支付宝账户
        /// </summary>
        [XmlElement("binding_alipay_logon_id")]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 证件名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 商户证件编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 商户联系人信息
        /// </summary>
        [XmlElement("contact_info")]
        public ZftContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 默认结算账号
        /// </summary>
        [XmlElement("default_settle_rule")]
        public ZftDefaultSettleRule DefaultSettleRule { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
