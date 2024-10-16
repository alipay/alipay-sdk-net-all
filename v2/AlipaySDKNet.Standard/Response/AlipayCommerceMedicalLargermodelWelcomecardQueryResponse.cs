using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelWelcomecardQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelWelcomecardQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data")]
        public CardContentDTO Data { get; set; }

        /// <summary>
        /// 业务处理成功
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
