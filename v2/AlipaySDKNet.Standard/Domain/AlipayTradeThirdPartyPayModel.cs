using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeThirdPartyPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeThirdPartyPayModel : AopObject
    {
        /// <summary>
        /// 代扣信息
        /// </summary>
        [XmlElement("agreement_params")]
        public AgreementParams AgreementParams { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 助贷平台PID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 资方和支付宝签约的产品码。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 资方在助贷平台侧入驻的smid
        /// </summary>
        [XmlElement("secondary_merchant_no")]
        public string SecondaryMerchantNo { get; set; }

        /// <summary>
        /// 订单标题 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
