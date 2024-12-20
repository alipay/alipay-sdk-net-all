using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquiryorderevaluateSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataInquiryorderevaluateSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝问诊订单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("evaluate_content")]
        public string EvaluateContent { get; set; }

        /// <summary>
        /// 评价标签
        /// </summary>
        [XmlElement("evaluate_label")]
        public string EvaluateLabel { get; set; }

        /// <summary>
        /// 评价分数 例如99、89
        /// </summary>
        [XmlElement("evaluate_score")]
        public string EvaluateScore { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }

        /// <summary>
        /// 外部平台用户id
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 评价是否可透出
        /// </summary>
        [XmlElement("open_status")]
        public bool OpenStatus { get; set; }

        /// <summary>
        /// 外部问诊订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部平台编号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
