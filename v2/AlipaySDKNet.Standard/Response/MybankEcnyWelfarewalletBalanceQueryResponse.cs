using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyWelfarewalletBalanceQueryResponse.
    /// </summary>
    public class MybankEcnyWelfarewalletBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 福利子钱包资产余额列表
        /// </summary>
        [XmlArray("account_balance_info_list")]
        [XmlArrayItem("account_balance_info")]
        public List<AccountBalanceInfo> AccountBalanceInfoList { get; set; }

        /// <summary>
        /// 子钱包余额，单位CNY
        /// </summary>
        [XmlElement("wallet_balance")]
        public string WalletBalance { get; set; }

        /// <summary>
        /// 福利子钱包编号
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }

        /// <summary>
        /// 钱包状态- NORMAL：正常 - FREEZE：冻结 - LOSS：挂失 - DEEP_FREEZE：深度冻结（注销前特定状态）
        /// </summary>
        [XmlElement("wallet_status")]
        public string WalletStatus { get; set; }
    }
}
