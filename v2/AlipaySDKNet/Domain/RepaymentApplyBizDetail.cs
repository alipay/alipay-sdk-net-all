using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymentApplyBizDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentApplyBizDetail : AopObject
    {
        /// <summary>
        /// 当期还款金额，单位：CNY
        /// </summary>
        [XmlElement("current_amt")]
        public string CurrentAmt { get; set; }

        /// <summary>
        /// 当期还款期数
        /// </summary>
        [XmlElement("install_num")]
        public long InstallNum { get; set; }

        /// <summary>
        /// 还款流水号（全局唯一）
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
