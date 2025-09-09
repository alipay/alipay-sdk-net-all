using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftSkuinfoSkuidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftSkuinfoSkuidQueryModel : AopObject
    {
        /// <summary>
        /// 数字藏品类标识ID
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
