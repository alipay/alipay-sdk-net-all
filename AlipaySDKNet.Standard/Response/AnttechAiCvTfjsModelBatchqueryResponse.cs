using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelBatchqueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// jsonString内容，不涉及商户敏感信息
        /// </summary>
        [XmlElement("model_info")]
        public string ModelInfo { get; set; }
    }
}
