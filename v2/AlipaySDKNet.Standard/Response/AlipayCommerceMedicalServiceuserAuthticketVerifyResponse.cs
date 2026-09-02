using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceuserAuthticketVerifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceuserAuthticketVerifyResponse : AopResponse
    {
        /// <summary>
        /// 扁鹊侧医生ID
        /// </summary>
        [XmlElement("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 阿福医生端医生ID
        /// </summary>
        [XmlElement("health_doc_id")]
        public string HealthDocId { get; set; }
    }
}
