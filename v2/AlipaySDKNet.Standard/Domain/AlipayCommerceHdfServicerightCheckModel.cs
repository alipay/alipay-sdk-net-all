using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHdfServicerightCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHdfServicerightCheckModel : AopObject
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 三方UID
        /// </summary>
        [XmlElement("open_partner_user_id")]
        public string OpenPartnerUserId { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
