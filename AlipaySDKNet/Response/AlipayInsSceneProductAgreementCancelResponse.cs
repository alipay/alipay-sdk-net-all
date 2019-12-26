using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneProductAgreementCancelResponse.
    /// </summary>
    public class AlipayInsSceneProductAgreementCancelResponse : AopResponse
    {
        /// <summary>
        /// 返回成功或者失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
