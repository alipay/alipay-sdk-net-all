using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceuserThirdhospitalSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceuserThirdhospitalSyncResponse : AopResponse
    {
        /// <summary>
        /// 健康账号ID
        /// </summary>
        [XmlElement("health_doc_id")]
        public string HealthDocId { get; set; }
    }
}
