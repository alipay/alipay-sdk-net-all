using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelSessionCancelResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelSessionCancelResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS：成功
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }
    }
}
