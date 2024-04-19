using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandBrandAssetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBrandAssetQueryModel : AopObject
    {
        /// <summary>
        /// 资产类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌运营主体的pid
        /// </summary>
        [XmlElement("carrier_id")]
        public string CarrierId { get; set; }

        /// <summary>
        /// 资产是否已确认 true=仅确认资产，false=仅未确认资产，null=所有资产
        /// </summary>
        [XmlElement("confirm")]
        public bool Confirm { get; set; }

        /// <summary>
        /// 页码，默认为1
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 单页行数，默认为10，最大不能超过100行
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
