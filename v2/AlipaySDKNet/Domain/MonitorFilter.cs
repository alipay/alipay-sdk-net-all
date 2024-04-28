using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MonitorFilter Data Structure.
    /// </summary>
    [Serializable]
    public class MonitorFilter : AopObject
    {
        /// <summary>
        /// cdn加速域名列表
        /// </summary>
        [XmlArray("cdn_domain_names")]
        [XmlArrayItem("string")]
        public List<string> CdnDomainNames { get; set; }

        /// <summary>
        /// 数据库集合列表
        /// </summary>
        [XmlArray("collections")]
        [XmlArrayItem("string")]
        public List<string> Collections { get; set; }

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
