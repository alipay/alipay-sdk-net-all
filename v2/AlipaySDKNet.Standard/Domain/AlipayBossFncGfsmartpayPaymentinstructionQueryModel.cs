using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsmartpayPaymentinstructionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsmartpayPaymentinstructionQueryModel : AopObject
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务单据号列
        /// </summary>
        [XmlElement("biz_document_nos")]
        public string BizDocumentNos { get; set; }

        /// <summary>
        /// 关联单据号列
        /// </summary>
        [XmlElement("related_document_nos")]
        public string RelatedDocumentNos { get; set; }
    }
}
