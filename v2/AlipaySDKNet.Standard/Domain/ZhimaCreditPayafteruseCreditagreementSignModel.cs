using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPayafteruseCreditagreementSignModel : AopObject
    {
        /// <summary>
        /// 当用户进入信用服务开通/授权页面后，点击左上角的回退按钮，中断开通流程，跳转回商户的页面地址。支持scheme协议。不传该链接时，默认返回上一级页面，由外部app唤起支付宝的情况，会返回支付宝首页。
        /// </summary>
        [XmlElement("cancel_back_link")]
        public string CancelBackLink { get; set; }

        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，暂无需传递。
        /// </summary>
        [XmlElement("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 业务扩展参数，用于商户的特定业务信息的传递，json格式。无特殊需求时，不需要传递该参数。
        /// </summary>
        [XmlElement("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 商户外部协议号，不同的支付宝用户需要传递不同的外部单号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 产品码，不填默认为 CREDIT_PAY_AFTER_USE。芝麻先享产品为CREDIT_PAY_AFTER_USE，其他产品请根据对应的技术支持文档传入。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户信用服务开通流程结束后，不区分用户开通成功/失败，跳转回商家页面，该字段代表跳转回商家的页面地址。支持scheme协议。不传该链接时，默认返回上一级页面，由外部app唤起支付宝的情况，会返回支付宝首页。
        /// </summary>
        [XmlElement("return_back_link")]
        public string ReturnBackLink { get; set; }

        /// <summary>
        /// 芝麻信用服务ID
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
