using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataHospitalUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataHospitalUploadResponse : AopResponse
    {
        /// <summary>
        /// 响应数据
        /// </summary>
        [XmlElement("data")]
        public CommerceDataUploadResponseData Data { get; set; }
    }
}
