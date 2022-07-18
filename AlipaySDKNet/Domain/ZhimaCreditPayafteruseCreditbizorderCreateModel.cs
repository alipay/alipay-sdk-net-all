using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPayafteruseCreditbizorderCreateModel : AopObject
    {
        /// <summary>
        /// 订单描述
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 当用户进入芝麻先享下单页面后，点击左上角的回退按钮，中断开通流程，跳转回商户的页面地址。不传该链接时，默认返回上一级页面，由外部app唤起支付宝的情况，会返回支付宝首页。
        /// </summary>
        [XmlElement("cancel_back_link")]
        public string CancelBackLink { get; set; }

        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 订单金额，该金额为当前订单扣款的累计最大额度。例如，下单时传递10.00，则扣款时最大支付金额为10元。若该参数不传，则默认使用商户签约时约定的上限额度。
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 商户外部协议号。不传该值时，默认使用out_order_no作为out_agreement_no使用，不同的支付宝用户需要传递不同的外部协议号。
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 商户外部订单号，保证不重复
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品码，不填默认为 CREDIT_PAY_AFTER_USE。芝麻先享产品为CREDIT_PAY_AFTER_USE，其他产品请根据对应的技术支持文档传入。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户成功完成芝麻先享开通流程后，跳转回商户的页面地址。不传该链接时，默认返回上一级页面，由外部app唤起支付宝的情况，会返回支付宝首页。
        /// </summary>
        [XmlElement("return_back_link")]
        public string ReturnBackLink { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 芝麻信用服务ID
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
