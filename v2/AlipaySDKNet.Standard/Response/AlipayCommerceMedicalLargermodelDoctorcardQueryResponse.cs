using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelDoctorcardQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelDoctorcardQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡片数据
        /// </summary>
        [XmlArray("llm_service_result")]
        [XmlArrayItem("llm_answer_card_d_t_o")]
        public List<LlmAnswerCardDTO> LlmServiceResult { get; set; }
    }
}
