using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeFinanceCreateResponse.
    /// </summary>
    public class AlipayTradeFinanceCreateResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段，返回保单号
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
