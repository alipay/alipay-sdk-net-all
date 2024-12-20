using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquiryorderstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataInquiryorderstatusSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 问诊订单回流接口出参的order_id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public PlatformInquiryOrderStatusExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 订单状态： 待支付：WAIT_PAY 已取消：CANCELED 待接诊：WAIT_INQUIRY 退款中：REFUNDING 已退款：REFUNDED 问诊中：IN_INQUIRY 退款申请中：REFUND_APPLYING 退款中：REFUNDING 已完成：FINISHED
        /// </summary>
        [XmlElement("merchant_order_status")]
        public string MerchantOrderStatus { get; set; }

        /// <summary>
        /// 平台用户id
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部问诊订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 平台编码号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
