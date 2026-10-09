using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneQuotationNimitzDimQueryResponse.
    /// </summary>
    public class AntfortuneQuotationNimitzDimQueryResponse : AopResponse
    {
        /// <summary>
        /// Nimitz 维度查询返回值，json形式
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 已弃用，返回时不要填充此字段，填充了也不会处理。
        /// </summary>
        [XmlElement("result_data")]
        public RsData ResultData { get; set; }

        /// <summary>
        /// 已弃用，返回时不要填充此字段，填充了也不会处理。
        /// </summary>
        [XmlElement("result_status")]
        public Status ResultStatus { get; set; }
    }
}
