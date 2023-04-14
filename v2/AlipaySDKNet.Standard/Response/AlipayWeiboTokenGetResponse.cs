using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayWeiboTokenGetResponse.
    /// </summary>
    public class AlipayWeiboTokenGetResponse : AopResponse
    {
        /// <summary>
        /// 访问账单查询的临时令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }
    }
}
