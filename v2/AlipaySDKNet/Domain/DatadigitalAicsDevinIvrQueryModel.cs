using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinIvrQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinIvrQueryModel : AopObject
    {
        /// <summary>
        /// 完整流程名称
        /// </summary>
        [XmlElement("complete_name")]
        public string CompleteName { get; set; }

        /// <summary>
        /// 流程使用环境（AssistantEnvEnum）：LATEST-最新版；PUB-线上版；NONE-所有版本
        /// </summary>
        [XmlElement("environment")]
        public string Environment { get; set; }

        /// <summary>
        /// 流程code
        /// </summary>
        [XmlElement("ivr_code")]
        public string IvrCode { get; set; }

        /// <summary>
        /// 流程名称关键字或流程ivrCode关键字（模糊匹配）
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("type_list")]
        [XmlArrayItem("string")]
        public List<string> TypeList { get; set; }

        /// <summary>
        /// 版本号（对客字段名 version_no，规避网关预留字 version）
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
