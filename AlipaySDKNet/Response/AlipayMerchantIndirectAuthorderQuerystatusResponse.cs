using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectAuthorderQuerystatusResponse.
    /// </summary>
    public class AlipayMerchantIndirectAuthorderQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 商家认证申请单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商家认证申请单状态，枚举值：审核中(AUDITING)、待联系人确认（CONTACT_CONFIRM），待法人确认（LEGAL_CONFIRM）、审核通过(AUDIT_PASS)、审核失败(AUDIT_REJECT)、已冻结(AUDIT_FREEZE)、已撤回(CANCELED)、联系人处理中（CONTACT_PROCESSING）
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商家认证小程序二维码图片链接，申请单状态处于审核通过、待联系人确认、待法人确认、已冻结、审核失败时返回，商户使用支付宝APP扫码后完成后续确认、修改信息等动作。 此字段是平台生成并返回的二维码码值，通过浏览器访问即可获得一个二维码的图片。服务商在推广过程中，可引导商家使用支付宝APP扫描此二维码，进入认证申请单页面，完成认证申请的后续确认操作。
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 申请单审核失败时的原因描述列表
        /// </summary>
        [XmlArray("verify_list")]
        [XmlArrayItem("indirect_auth_order_failed_reason")]
        public List<IndirectAuthOrderFailedReason> VerifyList { get; set; }
    }
}
