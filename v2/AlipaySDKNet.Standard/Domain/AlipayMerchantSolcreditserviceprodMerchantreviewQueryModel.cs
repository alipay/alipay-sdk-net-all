using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodMerchantreviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodMerchantreviewQueryModel : AopObject
    {
        /// <summary>
        /// 直付通进件
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
