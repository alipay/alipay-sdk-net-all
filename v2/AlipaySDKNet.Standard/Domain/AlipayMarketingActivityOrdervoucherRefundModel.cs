using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherRefundModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 当前订单的退券时间。    格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。    幂等作用：  参数不变的情况下，再次请求返回与上一次相同的结果。    外部接入方需保证业务单号唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 当前订单的退款总金额(包含优惠券金额)，单位为元。
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 已核销待退券的券码
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }

        /// <summary>
        /// 券取消核销详情
        /// </summary>
        [XmlElement("voucher_refund_detail_info")]
        public VoucherRefundDetailInfo VoucherRefundDetailInfo { get; set; }
    }
}
