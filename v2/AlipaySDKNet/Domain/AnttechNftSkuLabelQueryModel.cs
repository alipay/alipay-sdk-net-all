using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftSkuLabelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftSkuLabelQueryModel : AopObject
    {
        /// <summary>
        /// 藏品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
