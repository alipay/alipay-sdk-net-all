using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DamagesConsultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DamagesConsultInfo : AopObject
    {
        /// <summary>
        /// 是否可以退卡
        /// </summary>
        [XmlElement("can_close")]
        public bool CanClose { get; set; }

        /// <summary>
        /// 违约金最大值，单位：分
        /// </summary>
        [XmlElement("damages_cash")]
        public long DamagesCash { get; set; }

        /// <summary>
        /// 违约金比例，单位：%，例如返回值是30，代表30%
        /// </summary>
        [XmlElement("damages_rate")]
        public string DamagesRate { get; set; }

        /// <summary>
        /// 违约金类型
        /// </summary>
        [XmlElement("damages_type")]
        public string DamagesType { get; set; }

        /// <summary>
        /// 注意 如果售卖订单在7天内没有核销使用过，退卡时是没有违约金的
        /// </summary>
        [XmlElement("need_damages")]
        public bool NeedDamages { get; set; }

        /// <summary>
        /// 退卡金额，单位：分
        /// </summary>
        [XmlElement("refund_cash")]
        public long RefundCash { get; set; }

        /// <summary>
        /// 不可以退卡的原因
        /// </summary>
        [XmlElement("refuse_close_reason")]
        public string RefuseCloseReason { get; set; }
    }
}
