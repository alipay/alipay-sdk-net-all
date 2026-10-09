using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenYfxInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenYfxInfoDTO : AopObject
    {
        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlElement("auction_picture_url")]
        public string AuctionPictureUrl { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("auction_title")]
        public string AuctionTitle { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 理赔申请时间
        /// </summary>
        [XmlElement("claim_apply_time")]
        public string ClaimApplyTime { get; set; }

        /// <summary>
        /// 预计赔付时间
        /// </summary>
        [XmlElement("claim_expect_time")]
        public string ClaimExpectTime { get; set; }

        /// <summary>
        /// 理赔金额
        /// </summary>
        [XmlElement("claim_fee")]
        public string ClaimFee { get; set; }

        /// <summary>
        /// 理赔收入户
        /// </summary>
        [XmlElement("claim_in_account")]
        public string ClaimInAccount { get; set; }

        /// <summary>
        /// 理赔单号
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 拒赔code
        /// </summary>
        [XmlElement("claim_refuse_code")]
        public string ClaimRefuseCode { get; set; }

        /// <summary>
        /// 报案单号
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 理赔状态
        /// </summary>
        [XmlElement("claim_status")]
        public long ClaimStatus { get; set; }

        /// <summary>
        /// 首次理赔申请时间
        /// </summary>
        [XmlElement("first_claim_apply_time")]
        public string FirstClaimApplyTime { get; set; }

        /// <summary>
        /// 出单时间
        /// </summary>
        [XmlElement("issue_time")]
        public string IssueTime { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_gmt_create")]
        public string OrderGmtCreate { get; set; }

        /// <summary>
        /// 赔付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单状态
        /// </summary>
        [XmlElement("policy_status")]
        public long PolicyStatus { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 买家退货货物类型
        /// </summary>
        [XmlElement("refund_goods_type")]
        public long RefundGoodsType { get; set; }

        /// <summary>
        /// 退款单号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退货物流单号
        /// </summary>
        [XmlElement("refund_mail_no")]
        public string RefundMailNo { get; set; }

        /// <summary>
        /// 退货寄件方式
        /// </summary>
        [XmlElement("refund_post_type")]
        public string RefundPostType { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public long RefundStatus { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 运费险类型
        /// </summary>
        [XmlElement("yfx_type")]
        public string YfxType { get; set; }
    }
}
