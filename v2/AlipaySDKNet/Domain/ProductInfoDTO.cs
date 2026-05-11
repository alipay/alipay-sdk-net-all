using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ProductInfoDTO : AopObject
    {
        /// <summary>
        /// 预估价格，单位:元
        /// </summary>
        [XmlElement("estimate_premium")]
        public string EstimatePremium { get; set; }
    }
}
