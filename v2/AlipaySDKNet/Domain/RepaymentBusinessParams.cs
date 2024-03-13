using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymentBusinessParams Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentBusinessParams : AopObject
    {
        /// <summary>
        /// 转账到银行卡的预期到账时间，T0 表示预期 T+0 到账，T1 表示预期 T+1 到账，到账时效受银行机构处理影响，支付宝无法保证一定是 T0 或者 T1 到账
        /// </summary>
        [XmlElement("withdraw_timeliness")]
        public string WithdrawTimeliness { get; set; }
    }
}
