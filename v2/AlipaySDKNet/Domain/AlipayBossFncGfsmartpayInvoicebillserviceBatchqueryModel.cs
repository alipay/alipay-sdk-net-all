using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsmartpayInvoicebillserviceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsmartpayInvoicebillserviceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务单据号列表
        /// </summary>
        [XmlArray("biz_document_nos")]
        [XmlArrayItem("string")]
        public List<string> BizDocumentNos { get; set; }

        /// <summary>
        /// 关联单据号列表
        /// </summary>
        [XmlArray("related_document_nos")]
        [XmlArrayItem("string")]
        public List<string> RelatedDocumentNos { get; set; }

        /// <summary>
        /// 影子标记
        /// </summary>
        [XmlElement("test_mode")]
        public bool TestMode { get; set; }
    }
}
