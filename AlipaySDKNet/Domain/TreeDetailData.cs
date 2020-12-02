using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TreeDetailData Data Structure.
    /// </summary>
    [Serializable]
    public class TreeDetailData : AopObject
    {
        /// <summary>
        /// 证书申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 兑换树种获得的证书id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 是否合种。true：是合种，false：不是合种
        /// </summary>
        [XmlElement("cooperation")]
        public bool Cooperation { get; set; }

        /// <summary>
        /// 树种别名
        /// </summary>
        [XmlElement("tree_alias")]
        public string TreeAlias { get; set; }

        /// <summary>
        /// 树种类型，保护地【RESERVE】还是树苗【TREE】
        /// </summary>
        [XmlElement("tree_type")]
        public string TreeType { get; set; }
    }
}
