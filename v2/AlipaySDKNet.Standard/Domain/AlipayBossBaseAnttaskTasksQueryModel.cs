using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseAnttaskTasksQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseAnttaskTasksQueryModel : AopObject
    {
        /// <summary>
        /// 接入时的systemType
        /// </summary>
        [XmlElement("auth_key")]
        public string AuthKey { get; set; }

        /// <summary>
        /// 时间戳，到期时间
        /// </summary>
        [XmlElement("date_time")]
        public string DateTime { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        [XmlElement("query")]
        public TaskQuery Query { get; set; }

        /// <summary>
        /// 签名信息，不在此展示
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }
    }
}
