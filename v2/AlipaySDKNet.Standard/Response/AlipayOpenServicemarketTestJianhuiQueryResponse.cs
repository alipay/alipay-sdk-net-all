using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenServicemarketTestJianhuiQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketTestJianhuiQueryResponse : AopResponse
    {
        /// <summary>
        /// 接口请求成功
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
