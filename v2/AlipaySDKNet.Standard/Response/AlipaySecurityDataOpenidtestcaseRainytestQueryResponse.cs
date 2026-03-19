using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataOpenidtestcaseRainytestQueryResponse.
    /// </summary>
    public class AlipaySecurityDataOpenidtestcaseRainytestQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// OPENid 相关的映射类型
        /// </summary>
        [XmlElement("openid_complex")]
        public RainyComplexTypesTheThird OpenidComplex { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
