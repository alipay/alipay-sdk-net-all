using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAuthenticationTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAuthenticationTokenCreateModel : AopObject
    {
        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
