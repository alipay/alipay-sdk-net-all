using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelAgentwelcomecardQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelAgentwelcomecardQueryResponse : AopResponse
    {
        /// <summary>
        /// 欢迎页卡片数据
        /// </summary>
        [XmlElement("data")]
        public AgentWelcomeCardDTO Data { get; set; }

        /// <summary>
        /// 结果码
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
