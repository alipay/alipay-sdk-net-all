using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIParticipantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIParticipantInfo : AopObject
    {
        /// <summary>
        /// 参与者账户
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 参与者账户类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 参与者机构Id
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 参与者角色id（如支付宝中的uid）
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 参与者扩展信息。Map<String, String> 类型 JSON 字符串
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }
    }
}
