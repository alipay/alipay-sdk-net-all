using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrderConfirmResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrderConfirmResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
