using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OcpCloudSqlDumpTaskRes Data Structure.
    /// </summary>
    [Serializable]
    public class OcpCloudSqlDumpTaskRes : AopObject
    {
        /// <summary>
        /// 实例arn
        /// </summary>
        [XmlElement("cloud_instance_arn")]
        public string CloudInstanceArn { get; set; }

        /// <summary>
        /// [                     {                         "databaseName": "aaaliwei001",                         "tableNameList": [                             "atest001",                             "data08",                             "order"                         ]                     }                 ]
        /// </summary>
        [XmlArray("database_table_info")]
        [XmlArrayItem("database_table")]
        public List<DatabaseTable> DatabaseTableInfo { get; set; }

        /// <summary>
        /// 任务备注
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// oss下载链接
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 过期时间戳
        /// </summary>
        [XmlElement("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 文件大小，单位Byte
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 任务id，随机字符串
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// RUNNING、WAITING、FINISH
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
