using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExchangeDataItemResult Data Structure.
    /// </summary>
    [Serializable]
    public class ExchangeDataItemResult : AopObject
    {
        /// <summary>
        /// 属性Key（如userBaseInfo、education） 
        /// </summary>
        [XmlElement("attribute_key")]
        public string AttributeKey { get; set; }

        /// <summary>
        /// 属性名称（如"个人信息"、"学历学籍"） 
        /// </summary>
        [XmlElement("attribute_name")]
        public string AttributeName { get; set; }

        /// <summary>
        /// 认证来源（数据提供方appId）
        /// </summary>
        [XmlElement("cert_source")]
        public string CertSource { get; set; }

        /// <summary>
        /// 记录级认证状态（0-未认证，1-已认证）
        /// </summary>
        [XmlElement("cert_status")]
        public long CertStatus { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("field_info_result")]
        public List<FieldInfoResult> Fields { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("exchange_record_result")]
        public List<ExchangeRecordResult> Records { get; set; }

        /// <summary>
        /// 属性在办事保险箱中的表单类型
        /// </summary>
        [XmlElement("schema_type")]
        public string SchemaType { get; set; }
    }
}
