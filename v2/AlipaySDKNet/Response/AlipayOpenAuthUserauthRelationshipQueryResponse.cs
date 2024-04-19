using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationshipQueryResponse.
    /// </summary>
    public class AlipayOpenAuthUserauthRelationshipQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权结果查询结果，可以转换为为Map<String,Boolean>格式
        /// </summary>
        [XmlElement("query_detail")]
        public string QueryDetail { get; set; }
    }
}
