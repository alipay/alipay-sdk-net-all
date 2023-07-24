using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderIotUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderIotUploadModel : AopObject
    {
        /// <summary>
        /// 客户端接入结果页组件的abcp应用ID。另外要求该业务abcp_app_id需要和当前接口接入的appid归属为一个开发者pid
        /// </summary>
        [XmlElement("abcp_app_id")]
        public string AbcpAppId { get; set; }

        /// <summary>
        /// 交易实付金额，单位“分”；result_type非business_pay类型时必填
        /// </summary>
        [XmlElement("actual_pay_amount")]
        public long ActualPayAmount { get; set; }

        /// <summary>
        /// 实际支付时间
        /// </summary>
        [XmlElement("actual_pay_time")]
        public string ActualPayTime { get; set; }

        /// <summary>
        /// 复杂场景适配信息，result_type为business_pay类型时必填
        /// </summary>
        [XmlElement("business_infos")]
        public PaymentBusinessInfo BusinessInfos { get; set; }

        /// <summary>
        /// 找零金额，单位“分”
        /// </summary>
        [XmlElement("change_amount")]
        public long ChangeAmount { get; set; }

        /// <summary>
        /// 核销结果页，核销类信息
        /// </summary>
        [XmlArray("custom_infos")]
        [XmlArrayItem("custom_info")]
        public List<CustomInfo> CustomInfos { get; set; }

        /// <summary>
        /// 失败结果页信息提示内容
        /// </summary>
        [XmlElement("fail_info")]
        public string FailInfo { get; set; }

        /// <summary>
        /// 商家优惠金额，单位“分”，如果有多个优惠，请合并后填写总优惠；
        /// </summary>
        [XmlElement("merchant_discount_amount")]
        public long MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 订单原价，单位“分”
        /// </summary>
        [XmlElement("origin_amount")]
        public long OriginAmount { get; set; }

        /// <summary>
        /// 支付类结果，该字段则必填。支付类如果是组合支付，优先选用优先级高的支付渠道。(优先级alipay>wechat>others）。如：现金+支付宝支付，则传alipay
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 支付类结果页，该字段必填。字段代表支付来源，如刷脸支付，则传face，扫码支付，则传barcode，除此之外的则传others
        /// </summary>
        [XmlElement("pay_source")]
        public string PaySource { get; set; }

        /// <summary>
        /// 默认支付成功 success支付成功 fail 支付失败
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 结果页类型，非必填项，默认为支付类结果页。
        /// </summary>
        [XmlElement("result_type")]
        public string ResultType { get; set; }

        /// <summary>
        /// 业务来源，该字段由具体业务sop文档中分配。
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 客户端结果页组件上传的tradeNo保持一致,需保证业务唯一性
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
