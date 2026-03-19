using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndividuationEnableQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndividuationEnableQueryResponse : AopResponse
    {
        /// <summary>
        /// 机构智能体个性开启
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
