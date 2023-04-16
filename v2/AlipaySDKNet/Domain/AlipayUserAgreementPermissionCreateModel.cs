using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementPermissionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementPermissionCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务参数，如果notice_template是SERVIOCE_NOTICE时，此参数必传
        /// </summary>
        [XmlElement("business_params")]
        public BusinessParamsMap BusinessParams { get; set; }

        /// <summary>
        /// 目前共两种类型SERVIOCE_NOTICE和DEFAULT_PERMISSION，如果是服务变更提醒，需传入SERVIOCE_NOTICE
        /// </summary>
        [XmlElement("notice_template")]
        public string NoticeTemplate { get; set; }

        /// <summary>
        /// 商户请求号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
