using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalShortenurlExchangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalShortenurlExchangeModel : AopObject
    {
        /// <summary>
        /// 目标链接
        /// </summary>
        [XmlElement("target_url")]
        public string TargetUrl { get; set; }
    }
}
