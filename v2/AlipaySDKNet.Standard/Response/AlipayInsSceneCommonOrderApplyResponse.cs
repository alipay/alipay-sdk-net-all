using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonOrderApplyResponse.
    /// </summary>
    public class AlipayInsSceneCommonOrderApplyResponse : AopResponse
    {
        /// <summary>
        /// 保单摘要数据
        /// </summary>
        [XmlElement("policy")]
        public InsOpenPolicyDigestDTO Policy { get; set; }
    }
}
