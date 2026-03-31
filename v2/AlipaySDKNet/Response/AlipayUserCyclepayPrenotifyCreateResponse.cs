using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCyclepayPrenotifyCreateResponse.
    /// </summary>
    public class AlipayUserCyclepayPrenotifyCreateResponse : AopResponse
    {
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
    }
}
