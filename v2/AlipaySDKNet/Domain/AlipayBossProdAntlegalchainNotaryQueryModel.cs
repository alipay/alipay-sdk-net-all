using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNotaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainNotaryQueryModel : AopObject
    {
        /// <summary>
        /// 业务应用英文名
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 业务唯一流水id，业务数据请求唯一标识
        /// </summary>
        [XmlElement("business_unique_id")]
        public string BusinessUniqueId { get; set; }

        /// <summary>
        /// 业务系统被分配的密钥key
        /// </summary>
        [XmlElement("token_key")]
        public string TokenKey { get; set; }
    }
}
