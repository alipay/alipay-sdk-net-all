using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockLinkfundQueryResponse.
    /// </summary>
    public class AntfortuneStockLinkfundQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 关联的基金结果
        /// </summary>
        [XmlElement("data")]
        public OpenApiLinkFundResponse Data { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
