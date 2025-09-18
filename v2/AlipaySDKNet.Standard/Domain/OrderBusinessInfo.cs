using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderBusinessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderBusinessInfo : AopObject
    {
        /// <summary>
        /// 本次从卡内消费的金额，阿拉伯数字，单位：元，小数点后两位。或者是其他剩余卡权益的相关
        /// </summary>
        [XmlElement("card_balance")]
        public string CardBalance { get; set; }

        /// <summary>
        /// 绑定卡片名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 餐卡卡号
        /// </summary>
        [XmlElement("cardid")]
        public string Cardid { get; set; }

        /// <summary>
        /// 消费金额，单位：元
        /// </summary>
        [XmlElement("consumption_amount")]
        public string ConsumptionAmount { get; set; }

        /// <summary>
        /// 餐卡消费的具体项目
        /// </summary>
        [XmlElement("consumption_project")]
        public string ConsumptionProject { get; set; }

        /// <summary>
        /// 餐卡消费详情
        /// </summary>
        [XmlElement("details")]
        public string Details { get; set; }

        /// <summary>
        /// 充值金额，单位：元
        /// </summary>
        [XmlElement("recharge_amount")]
        public string RechargeAmount { get; set; }

        /// <summary>
        /// 充值时间
        /// </summary>
        [XmlElement("recharge_time")]
        public string RechargeTime { get; set; }

        /// <summary>
        /// 退款金额，单位：元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 餐卡消费温馨提示
        /// </summary>
        [XmlElement("reminder")]
        public string Reminder { get; set; }
    }
}
