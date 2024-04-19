using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdEventActionModifyResponse.
    /// </summary>
    public class AlipaySecurityProdEventActionModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回状态码 200 成功 500 失败
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
