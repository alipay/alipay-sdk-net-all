using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MonitorFilter Data Structure.
    /// </summary>
    [Serializable]
    public class MonitorFilter : AopObject
    {
        /// <summary>
        /// 按照函数名称过滤
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 数据库操作类型  - Read  - Write
        /// </summary>
        [XmlElement("mongodb_operation")]
        public string MongodbOperation { get; set; }

        /// <summary>
        /// OSS操作类型  - Upload  - Download  - Delete
        /// </summary>
        [XmlElement("oss_operation")]
        public string OssOperation { get; set; }
    }
}
