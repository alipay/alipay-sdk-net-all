using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractDownloadModel : AopObject
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 文件的fileKey
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 当前系统名称
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
