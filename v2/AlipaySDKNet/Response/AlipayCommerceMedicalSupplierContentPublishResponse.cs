using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSupplierContentPublishResponse.
    /// </summary>
    public class AlipayCommerceMedicalSupplierContentPublishResponse : AopResponse
    {
        /// <summary>
        /// 医疗侧生成的供给ID
        /// </summary>
        [XmlElement("med_content_id")]
        public string MedContentId { get; set; }
    }
}
