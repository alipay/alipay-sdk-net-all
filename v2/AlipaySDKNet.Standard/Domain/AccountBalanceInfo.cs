using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountBalanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AccountBalanceInfo : AopObject
    {
        /// <summary>
        /// 费控id
        /// </summary>
        [XmlElement("rule_group_id")]
        public string RuleGroupId { get; set; }

        /// <summary>
        /// 福利资产余额，单位CNY
        /// </summary>
        [XmlElement("welfare_asset_balance")]
        public string WelfareAssetBalance { get; set; }

        /// <summary>
        /// 福利资产编号
        /// </summary>
        [XmlElement("welfare_asset_id")]
        public string WelfareAssetId { get; set; }
    }
}
