using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardRechargeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CardRechargeDetail : AopObject
    {
        /// <summary>
        /// 充值订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 充值失败信息
        /// </summary>
        [XmlElement("recharge_fail_msg")]
        public string RechargeFailMsg { get; set; }

        /// <summary>
        /// 充值费用，单位：分
        /// </summary>
        [XmlElement("recharge_fee")]
        public long RechargeFee { get; set; }

        /// <summary>
        /// 充值流量，单位MB
        /// </summary>
        [XmlElement("recharge_flow")]
        public string RechargeFlow { get; set; }

        /// <summary>
        /// 充值状态
        /// </summary>
        [XmlElement("recharge_status")]
        public string RechargeStatus { get; set; }

        /// <summary>
        /// 充值时间
        /// </summary>
        [XmlElement("recharge_time")]
        public string RechargeTime { get; set; }
    }
}
