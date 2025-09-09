using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonEndorseperiodApplyResponse.
    /// </summary>
    public class AlipayInsSceneCommonEndorseperiodApplyResponse : AopResponse
    {
        /// <summary>
        /// 批单号
        /// </summary>
        [XmlElement("endorse_no")]
        public string EndorseNo { get; set; }
    }
}
