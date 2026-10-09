using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHospitalorderUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHospitalorderUploadModel : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public MedicalHospitalOrderUploadExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("merchant_order_status")]
        public string MerchantOrderStatus { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户订单id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部订单类型 HOSPITAL_APPOINTMENT - 挂号单 HOSPITAL_CHECK - 检查单 HOSPITAL_MEDICINE - 医药单 HOSPITAL_PAYMENT - 支付单
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 平台商ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
