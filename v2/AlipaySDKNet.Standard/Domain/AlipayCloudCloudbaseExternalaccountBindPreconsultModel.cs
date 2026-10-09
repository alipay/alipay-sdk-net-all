using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseExternalaccountBindPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseExternalaccountBindPreconsultModel : AopObject
    {
        /// <summary>
        /// 服务商用户账号，如邮箱地址、手机号等
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 服务商用户账号名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 实体名称
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 实体类型
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }
    }
}
