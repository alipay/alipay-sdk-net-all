using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodMerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodMerchantQueryModel : AopObject
    {
        /// <summary>
        /// 直付通进件后获取
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
