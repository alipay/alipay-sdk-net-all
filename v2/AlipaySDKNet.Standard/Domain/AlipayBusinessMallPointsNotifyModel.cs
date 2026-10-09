using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessMallPointsNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessMallPointsNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// buyer_open_id是用户（UserId）在应用（AppId）下的唯一用户标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 用于标明此单是否获得积分， true为获得积分， false为未获得
        /// </summary>
        [XmlElement("earn_points")]
        public bool EarnPoints { get; set; }

        /// <summary>
        /// 当未获得积分时，提供未获得积分的原因等备注信息
        /// </summary>
        [XmlElement("no_points_remarks")]
        public string NoPointsRemarks { get; set; }

        /// <summary>
        /// 此单获得积分数
        /// </summary>
        [XmlElement("obtain_points")]
        public long ObtainPoints { get; set; }

        /// <summary>
        /// 此笔订单积分处理成功的时间
        /// </summary>
        [XmlElement("points_update_time")]
        public string PointsUpdateTime { get; set; }

        /// <summary>
        /// 顾客积分总额
        /// </summary>
        [XmlElement("total_points")]
        public long TotalPoints { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
