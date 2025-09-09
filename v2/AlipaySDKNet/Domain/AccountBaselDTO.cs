using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountBaselDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AccountBaselDTO : AopObject
    {
        /// <summary>
        /// 小荷包账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 账户名称开户时传入
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户状态
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 授权协议号支付宝侧生成
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 当前可用金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("available_balance")]
        public string AvailableBalance { get; set; }

        /// <summary>
        /// 当前冻结金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("freeze_balance")]
        public string FreezeBalance { get; set; }

        /// <summary>
        /// 生息状态
        /// </summary>
        [XmlElement("profit_status")]
        public string ProfitStatus { get; set; }

        /// <summary>
        /// 昨日收益（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("yesterday_profit")]
        public string YesterdayProfit { get; set; }
    }
}
