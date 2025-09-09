using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalNpsStatusQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalNpsStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// true：需要弹nps卡片 false：不需要弹nps卡片
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
