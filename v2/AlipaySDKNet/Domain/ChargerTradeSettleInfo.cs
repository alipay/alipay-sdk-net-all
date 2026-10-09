using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargerTradeSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChargerTradeSettleInfo : AopObject
    {
        /// <summary>
        /// 垫资状态
        /// </summary>
        [XmlElement("advance_pay_status")]
        public string AdvancePayStatus { get; set; }

        /// <summary>
        /// 该笔交易的买家付款时间。格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 本次交易用户应付的订单金额。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }
    }
}
