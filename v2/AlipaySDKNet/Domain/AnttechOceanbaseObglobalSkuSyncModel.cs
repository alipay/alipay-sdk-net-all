using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSkuSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSkuSyncModel : AopObject
    {
        /// <summary>
        /// 商品sku信息
        /// </summary>
        [XmlElement("sku_info")]
        public string SkuInfo { get; set; }

        /// <summary>
        /// 初始化sku
        /// </summary>
        [XmlElement("sku_init")]
        public bool SkuInit { get; set; }
    }
}
