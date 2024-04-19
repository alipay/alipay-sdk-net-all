using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetIssueApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAssetIssueApplyModel : AopObject
    {
        /// <summary>
        /// 资产类型，依赖业务对接时约定的枚举值
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 当asset_type为RECEIVABLE时必填，应收账款信息
        /// </summary>
        [XmlElement("receivable_info")]
        public FinanceReceivableInfo ReceivableInfo { get; set; }
    }
}
