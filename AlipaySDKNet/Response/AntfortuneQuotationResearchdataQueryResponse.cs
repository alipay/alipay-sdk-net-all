using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneQuotationResearchdataQueryResponse.
    /// </summary>
    public class AntfortuneQuotationResearchdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 金融信息数据返回值，datatable的json形式。
        /// </summary>
        [XmlElement("result_content")]
        public string ResultContent { get; set; }

        /// <summary>
        /// 结果的描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 是否本次请求成功
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }
    }
}
