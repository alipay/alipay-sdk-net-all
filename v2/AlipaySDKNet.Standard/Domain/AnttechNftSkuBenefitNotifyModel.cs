using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftSkuBenefitNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftSkuBenefitNotifyModel : AopObject
    {
        /// <summary>
        /// nft编号
        /// </summary>
        [XmlElement("nft_id")]
        public string NftId { get; set; }

        /// <summary>
        /// sku编码
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
