using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonPolicyCancelResponse.
    /// </summary>
    public class AlipayInsSceneCommonPolicyCancelResponse : AopResponse
    {
        /// <summary>
        /// 批单号
        /// </summary>
        [XmlElement("endorse_no")]
        public string EndorseNo { get; set; }
    }
}
