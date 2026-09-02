using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferApplyBizDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TransferApplyBizDetail : AopObject
    {
        /// <summary>
        /// 还款总金额，单位：CNY
        /// </summary>
        [XmlElement("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 罚金，单位：CNY
        /// </summary>
        [XmlElement("penalty")]
        public string Penalty { get; set; }

        /// <summary>
        /// 还款本金，单位：CNY
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 还款类型
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }

        /// <summary>
        /// 服务费，单位：CNY
        /// </summary>
        [XmlElement("service_fee")]
        public string ServiceFee { get; set; }

        /// <summary>
        /// 当期期数
        /// </summary>
        [XmlElement("step_no")]
        public long StepNo { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
