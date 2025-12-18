using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserOwnedAsset Data Structure.
    /// </summary>
    [Serializable]
    public class UserOwnedAsset : AopObject
    {
        /// <summary>
        /// 用户持有该sku资产的数据
        /// </summary>
        [XmlElement("owned_sku_asset_num")]
        public long OwnedSkuAssetNum { get; set; }

        /// <summary>
        /// sku的Id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }
    }
}
