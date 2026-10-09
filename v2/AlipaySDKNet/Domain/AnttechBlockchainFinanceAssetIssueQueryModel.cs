using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetIssueQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAssetIssueQueryModel : AopObject
    {
        /// <summary>
        /// 资产发行提交时传入的内部资产id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产对应的核心企业信息
        /// </summary>
        [XmlElement("core_business_info")]
        public FinanceMemberInfo CoreBusinessInfo { get; set; }
    }
}
