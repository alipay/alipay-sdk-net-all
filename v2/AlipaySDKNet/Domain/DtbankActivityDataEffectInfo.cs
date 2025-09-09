using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtbankActivityDataEffectInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtbankActivityDataEffectInfo : AopObject
    {
        /// <summary>
        /// 笔均核销优惠金额，单位：分
        /// </summary>
        [XmlElement("avg_order_write_off_discount_amt")]
        public long AvgOrderWriteOffDiscountAmt { get; set; }

        /// <summary>
        /// 人均核销优惠金额，单位：分
        /// </summary>
        [XmlElement("avg_user_write_off_discount_amt")]
        public long AvgUserWriteOffDiscountAmt { get; set; }

        /// <summary>
        /// 取数据更新的截止日期
        /// </summary>
        [XmlElement("data_update_time")]
        public string DataUpdateTime { get; set; }

        /// <summary>
        /// 累计退款活动金额，单位：分
        /// </summary>
        [XmlElement("total_camp_refund_amt")]
        public long TotalCampRefundAmt { get; set; }

        /// <summary>
        /// 失效优惠券金额，单位：分
        /// </summary>
        [XmlElement("total_expire_amt")]
        public long TotalExpireAmt { get; set; }

        /// <summary>
        /// 失效优惠券数量，单位：个
        /// </summary>
        [XmlElement("total_expire_cnt")]
        public long TotalExpireCnt { get; set; }

        /// <summary>
        /// 累计退款订单数，单位：笔
        /// </summary>
        [XmlElement("total_order_refund_cnt")]
        public long TotalOrderRefundCnt { get; set; }

        /// <summary>
        /// 累积领取优惠金额，单位：分
        /// </summary>
        [XmlElement("total_receive_amt")]
        public long TotalReceiveAmt { get; set; }

        /// <summary>
        /// 累积领取次数，单位：次
        /// </summary>
        [XmlElement("total_receive_times")]
        public long TotalReceiveTimes { get; set; }

        /// <summary>
        /// 累计领取用户数，单位：个
        /// </summary>
        [XmlElement("total_receive_user_cnt")]
        public long TotalReceiveUserCnt { get; set; }

        /// <summary>
        /// 累积核销优惠金额，单位：分
        /// </summary>
        [XmlElement("total_write_off_discount_amt")]
        public long TotalWriteOffDiscountAmt { get; set; }

        /// <summary>
        /// 累积核销订单数，单位：笔
        /// </summary>
        [XmlElement("total_write_off_order_cnt")]
        public long TotalWriteOffOrderCnt { get; set; }

        /// <summary>
        /// 累积核销用户数，单位：个
        /// </summary>
        [XmlElement("total_write_off_user_cnt")]
        public long TotalWriteOffUserCnt { get; set; }
    }
}
