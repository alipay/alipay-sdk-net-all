using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthAppContentQueryResponse.
    /// </summary>
    public class AlipayOpenAuthAppContentQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权协议列表
        /// </summary>
        [XmlArray("agreement")]
        [XmlArrayItem("agreement")]
        public List<Agreement> Agreement { get; set; }

        /// <summary>
        /// 授权范围描述
        /// </summary>
        [XmlArray("auth_text")]
        [XmlArrayItem("string")]
        public List<string> AuthText { get; set; }
    }
}
