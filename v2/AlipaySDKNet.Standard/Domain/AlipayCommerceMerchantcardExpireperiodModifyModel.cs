using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardExpireperiodModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardExpireperiodModifyModel : AopObject
    {
        /// <summary>
        /// 将售卖订单的有效期延期到入参的时间点{appoint_date}，时间格式是yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("appoint_date")]
        public string AppointDate { get; set; }

        /// <summary>
        /// 售卖订单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 幂等键
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 指定从第几期开始延期
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 按周延期还是按月延期
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 【update_type=FIXED】代表延期几个周期，单位是周/月 【update_type=APPOINT】代表延期几天，单位是天
        /// </summary>
        [XmlElement("period_value")]
        public long PeriodValue { get; set; }

        /// <summary>
        /// 【注意】 周期卡：如果指定的期数已经被核销了则不允许延期； 次卡：只能使用APPOINT模式 【FIXED】将指定期数及后续期数按固定周期延；月卡、季卡必须按照月延期；周卡必须按照周延期；日卡不支持按固定周期延 【APPOINT】将指定期数及后续期数都延长{period_value}天 【RECAST】将指定期数延长{period_value}天，后续期数会自动按周期延
        /// </summary>
        [XmlElement("update_type")]
        public string UpdateType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
