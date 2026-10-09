using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinanceReceivableResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinanceReceivableResultInfo : AopObject
    {
        /// <summary>
        /// 供应商确认接收上链交易hash
        /// </summary>
        [XmlElement("accept_tx_hash")]
        public string AcceptTxHash { get; set; }

        /// <summary>
        /// 资产发行提交时传入的内部资产id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 保理付款账户信息
        /// </summary>
        [XmlElement("factoring_account_info")]
        public FinanceBankAccountInfo FactoringAccountInfo { get; set; }

        /// <summary>
        /// 发行完成时间，UTC标准格式
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 资产发行预申请时，核心企业定义的应收账款编号
        /// </summary>
        [XmlElement("out_asset_id")]
        public string OutAssetId { get; set; }

        /// <summary>
        /// 保理机构登记审批上链交易hash
        /// </summary>
        [XmlElement("review_tx_hash")]
        public string ReviewTxHash { get; set; }

        /// <summary>
        /// 核心企业提交上链交易hash
        /// </summary>
        [XmlElement("submit_tx_hash")]
        public string SubmitTxHash { get; set; }
    }
}
