using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtAppDetecttaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtAppDetecttaskCreateModel : AopObject
    {
        /// <summary>
        /// app检测参数
        /// </summary>
        [XmlElement("app_param")]
        public ApmobileAppParam AppParam { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 来源站点
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 请求幂等校验id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
