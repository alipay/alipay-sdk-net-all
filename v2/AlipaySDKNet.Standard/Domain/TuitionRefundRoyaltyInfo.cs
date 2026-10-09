using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionRefundRoyaltyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionRefundRoyaltyInfo : AopObject
    {
        /// <summary>
        /// 退分账金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 分账百分比，0-100
        /// </summary>
        [XmlElement("amount_percent")]
        public long AmountPercent { get; set; }

        /// <summary>
        /// 分账类型：普通分账为：transfer；补差为：replenish 默认为分账
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 收入方支付宝uid，分账类型为replenish时必填
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 退分账转出支付宝uid，分账类型为transfer时必填
        /// </summary>
        [XmlElement("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 账户类型：1-支付宝账号对应的支付宝唯一用户号； 2-卡编号； 3-支付宝登录号；
        /// </summary>
        [XmlElement("trans_type")]
        public string TransType { get; set; }
    }
}
