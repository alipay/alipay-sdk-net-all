using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleInfoListDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SettleInfoListDTO : AopObject
    {
        /// <summary>
        /// 分账失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 百分比，最多两位小数
        /// </summary>
        [XmlElement("separate_ledger_rate")]
        public string SeparateLedgerRate { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 服务商默认账户: ISV_DEFAULT 其余分账账户: OTHER_ACCOUNT
        /// </summary>
        [XmlElement("settle_role")]
        public string SettleRole { get; set; }

        /// <summary>
        /// 待分账: WAIT_SETTLE 分账中: SETTLING 分账成功: SETTLE_SUCCESS 分账失败: SETTLE_FAIL
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 分账触发时间
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 收款分账账户
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 用户号: userId 支付宝登录号: loginName
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }
    }
}
