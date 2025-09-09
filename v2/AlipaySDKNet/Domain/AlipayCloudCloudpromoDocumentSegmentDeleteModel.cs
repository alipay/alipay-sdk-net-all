using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoDocumentSegmentDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoDocumentSegmentDeleteModel : AopObject
    {
        /// <summary>
        /// API-Key
        /// </summary>
        [XmlElement("api_key")]
        public string ApiKey { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("chunks")]
        [XmlArrayItem("string")]
        public List<string> Chunks { get; set; }

        /// <summary>
        /// 客户id 
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 要删除的分段所属应用数据ID
        /// </summary>
        [XmlElement("document_id")]
        public string DocumentId { get; set; }

        /// <summary>
        /// 操作人标识
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 空间ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
