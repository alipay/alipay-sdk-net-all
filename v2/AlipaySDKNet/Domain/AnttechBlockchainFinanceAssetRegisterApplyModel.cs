using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRegisterApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAssetRegisterApplyModel : AopObject
    {
        /// <summary>
        /// 资产详情，不同资产类型格式不同。
        /// </summary>
        [XmlElement("asset_info")]
        public string AssetInfo { get; set; }

        /// <summary>
        /// 资产类型，依赖业务对接时约定的枚举值
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 外部资产编号
        /// </summary>
        [XmlElement("out_asset_id")]
        public string OutAssetId { get; set; }
    }
}
