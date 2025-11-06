using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneClaimOverdueCloseResponse.
    /// </summary>
    public class AlipayInsSceneClaimOverdueCloseResponse : AopResponse
    {
        /// <summary>
        /// 追偿单号
        /// </summary>
        [XmlElement("overdue_no")]
        public string OverdueNo { get; set; }
    }
}
