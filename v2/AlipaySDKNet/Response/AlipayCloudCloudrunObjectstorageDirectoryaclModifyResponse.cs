using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageDirectoryaclModifyResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageDirectoryaclModifyResponse : AopResponse
    {
        /// <summary>
        /// 访问属性
        /// </summary>
        [XmlElement("acl")]
        public string Acl { get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件夹名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 上次更新时间
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }
    }
}
