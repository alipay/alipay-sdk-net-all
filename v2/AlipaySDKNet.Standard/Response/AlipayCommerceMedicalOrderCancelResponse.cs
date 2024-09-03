using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrderCancelResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrderCancelResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
