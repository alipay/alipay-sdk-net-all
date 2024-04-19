using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDoctorUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataDoctorUploadResponse : AopResponse
    {
        /// <summary>
        /// 业务响应数据
        /// </summary>
        [XmlElement("data")]
        public CommerceDataUploadResponseData Data { get; set; }
    }
}
