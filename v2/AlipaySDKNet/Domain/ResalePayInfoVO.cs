using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResalePayInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ResalePayInfoVO : AopObject
    {
        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付说明
        /// </summary>
        [XmlElement("pay_memo")]
        public string PayMemo { get; set; }

        /// <summary>
        /// SEND_BACK_LOGISTICS_FEE（退货物流费）、COMPENSATION_FEE（物品赔付费）。总费用不能超过订单总金额
        /// </summary>
        [XmlElement("pay_scene")]
        public string PayScene { get; set; }
    }
}
