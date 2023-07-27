using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageObjectaclModifyResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageObjectaclModifyResponse : AopResponse
    {
        /// <summary>
        /// 文件acl，取值default：默认，acl继承自桶的acl；private: 私有，公网无法直接访问获取；public-read: 公开，公网可以直接访问获取
        /// </summary>
        [XmlElement("acl")]
        public string Acl { get; set; }

        /// <summary>
        /// 文件ID(唯一)，文件的唯一索引ID，上传文件后系统会创建返回该文件的文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小，单位为Byte
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 文件状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
