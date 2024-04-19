using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementPermissionCreateResponse.
    /// </summary>
    public class AlipayUserAgreementPermissionCreateResponse : AopResponse
    {
        /// <summary>
        /// 商户代扣扣款许可
        /// </summary>
        [XmlElement("deduct_permission")]
        public string DeductPermission { get; set; }

        /// <summary>
        /// 商户代扣扣款许可生效结束时间
        /// </summary>
        [XmlElement("effective_time_end")]
        public string EffectiveTimeEnd { get; set; }

        /// <summary>
        /// 商户代扣扣款许可生效开始时间
        /// </summary>
        [XmlElement("effective_time_start")]
        public string EffectiveTimeStart { get; set; }

        /// <summary>
        /// 消息是否发送成功
        /// </summary>
        [XmlElement("is_success_send")]
        public bool IsSuccessSend { get; set; }
    }
}
