using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagOperationRequest Data Structure.
    /// </summary>
    [Serializable]
    public class TagOperationRequest : AopObject
    {
        /// <summary>
        /// 标签所属表的key
        /// </summary>
        [XmlElement("domain_table_key")]
        public string DomainTableKey { get; set; }

        /// <summary>
        /// 标识是打标操作还是去标操作
        /// </summary>
        [XmlElement("operation_code")]
        public string OperationCode { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 被打标的资源ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 标签值的key
        /// </summary>
        [XmlArray("tag_api_name_list")]
        [XmlArrayItem("string")]
        public List<string> TagApiNameList { get; set; }
    }
}
