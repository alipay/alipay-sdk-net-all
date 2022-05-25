using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationCancelResponse.
    /// </summary>
    public class AlipayOpenAuthUserauthRelationCancelResponse : AopResponse
    {
        /// <summary>
        /// 操作结果，成功or失败
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
