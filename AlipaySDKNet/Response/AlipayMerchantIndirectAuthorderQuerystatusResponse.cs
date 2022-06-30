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
        /// 意愿申请单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 意愿申请单状态，枚举值：审核中(AUDITING)、待联系人确认（CONTACT_CONFIRM），待法人确认（LEGAL_CONFIRM）、审核通过(AUDIT_PASS)、审核失败(AUDIT_REJECT)、已冻结(AUDIT_FREEZE)、已撤回(CANCELED)
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 意愿申请小程序二维码图片链接，申请单状态处于审核成功、审核中、已冻结时返回，商户使用支付宝APP扫码后完成后续确认动作
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 订单审核失败时的原因描述列表
        /// </summary>
        [XmlArray("verify_list")]
        [XmlArrayItem("indirect_auth_order_failed_reason")]
        public List<IndirectAuthOrderFailedReason> VerifyList { get; set; }
    }
}
