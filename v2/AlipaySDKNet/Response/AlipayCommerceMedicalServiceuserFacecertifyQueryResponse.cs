using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceuserFacecertifyQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceuserFacecertifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 人脸核身查询结果
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
