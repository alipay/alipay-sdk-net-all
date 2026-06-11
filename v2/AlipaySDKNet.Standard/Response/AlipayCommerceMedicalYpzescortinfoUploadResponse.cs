using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzescortinfoUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzescortinfoUploadResponse : AopResponse
    {
        /// <summary>
        /// 陪诊单id
        /// </summary>
        [XmlElement("escort_id")]
        public string EscortId { get; set; }
    }
}
