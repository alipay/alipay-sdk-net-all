using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneQuotationQuoteinfoprodNlqueryQueryResponse.
    /// </summary>
    public class AntfortuneQuotationQuoteinfoprodNlqueryQueryResponse : AopResponse
    {
        /// <summary>
        /// 模型处理结果
        /// </summary>
        [XmlElement("data")]
        public NLResultDTO Data { get; set; }
    }
}
