using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDeloauthDetailQueryResponse.
    /// </summary>
    public class AlipayUserDeloauthDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 解除授权记录列表
        /// </summary>
        [XmlElement("response")]
        public DelOauthDetailResult Response { get; set; }
    }
}
