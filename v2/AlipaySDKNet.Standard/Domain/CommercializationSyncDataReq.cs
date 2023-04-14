using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommercializationSyncDataReq Data Structure.
    /// </summary>
    [Serializable]
    public class CommercializationSyncDataReq : AopObject
    {
        /// <summary>
        /// 数据文件链接  可访问的csv文件
        /// </summary>
        [XmlElement("data_link")]
        public string DataLink { get; set; }

        /// <summary>
        /// 同步数据类型，固定类型
        /// </summary>
        [XmlElement("data_sync_type")]
        public string DataSyncType { get; set; }

        /// <summary>
        /// 文件接口返回的fileId，也就是oss的objectKey
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 提交唯一标识，幂等性验证
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 同步时间戳
        /// </summary>
        [XmlElement("sync_timestamp")]
        public string SyncTimestamp { get; set; }
    }
}
