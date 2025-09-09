using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MrchBrandInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MrchBrandInfo : AopObject
    {
        /// <summary>
        /// 具体值需由支付宝分配
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }
    }
}
