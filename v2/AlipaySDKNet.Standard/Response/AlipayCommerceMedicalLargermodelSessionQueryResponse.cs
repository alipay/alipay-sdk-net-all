using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelSessionQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelSessionQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("llm_service_result")]
        public LlmServiceDTO LlmServiceResult { get; set; }

        /// <summary>
        /// SUCCESS：业务处理成功
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
