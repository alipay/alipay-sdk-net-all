using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceAdvancepaySyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceAdvancepaySyncResponse : AopResponse
    {
        /// <summary>
        /// 同步返回值
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
