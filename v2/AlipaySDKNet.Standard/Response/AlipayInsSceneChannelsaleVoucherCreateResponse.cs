using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneChannelsaleVoucherCreateResponse.
    /// </summary>
    public class AlipayInsSceneChannelsaleVoucherCreateResponse : AopResponse
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
        /// 凭证编码
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }

        /// <summary>
        /// 凭证领取URL
        /// </summary>
        [XmlElement("voucher_url")]
        public string VoucherUrl { get; set; }
    }
}
