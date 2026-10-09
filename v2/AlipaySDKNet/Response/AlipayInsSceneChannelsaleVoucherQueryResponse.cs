using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneChannelsaleVoucherQueryResponse.
    /// </summary>
    public class AlipayInsSceneChannelsaleVoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 凭证失效时间
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 凭证生效时间
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 凭证状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 凭证核销地址
        /// </summary>
        [XmlElement("voucher_url")]
        public string VoucherUrl { get; set; }
    }
}
