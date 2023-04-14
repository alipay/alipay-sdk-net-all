using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudFileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudFileQueryModel : AopObject
    {
        /// <summary>
        /// 云环境ID,在云托管平台获取
        /// </summary>
        [XmlElement("cloud_id")]
        public string CloudId { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
