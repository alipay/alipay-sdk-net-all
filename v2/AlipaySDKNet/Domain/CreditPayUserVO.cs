using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPayUserVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayUserVO : AopObject
    {
        /// <summary>
        /// 开放id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝UID，可选
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 证件号，可选，如果存在，certType一定要存在。在返回结果中 ps. cert_no一定不存在
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，可选，如果存在，certNo一定要存在 类型：身份证RESIDENT、社会统一信用码UNIFIED_SOCIAL_CREDIT_CODE_CERTIFICATE
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 网商会员ID，可选，如果该字段存在，ip_role_id一定要存在
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商会员角色ID，可选，如果该字段存在，ip_id一定要存在
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 可选，如果站点存在，site_user_id一定存在 1.ALIPAY(支付宝) 2.TAOBAO(淘宝) 3.CBU(中文站) 4.ICBU(国际站)
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 可选，如果站点用户ID存在，site一定存在
        /// </summary>
        [XmlElement("site_open_id")]
        public string SiteOpenId { get; set; }

        /// <summary>
        /// 可选，如果站点用户ID存在，site一定存在
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
