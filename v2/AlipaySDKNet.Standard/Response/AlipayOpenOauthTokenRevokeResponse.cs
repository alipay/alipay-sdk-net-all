using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOauthTokenRevokeResponse.
    /// </summary>
    public class AlipayOpenOauthTokenRevokeResponse : AopResponse
    {
        /// <summary>
        /// 处理结果，成功or失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
