using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftDeleteModel : AopObject
    {
        /// <summary>
        /// 直付通二级商户smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
