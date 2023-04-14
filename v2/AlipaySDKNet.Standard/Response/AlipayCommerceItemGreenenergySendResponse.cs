using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceItemGreenenergySendResponse.
    /// </summary>
    public class AlipayCommerceItemGreenenergySendResponse : AopResponse
    {
        /// <summary>
        /// 能量数量,单位g
        /// </summary>
        [XmlElement("energy_amount")]
        public long EnergyAmount { get; set; }

        /// <summary>
        /// 绿色行为描述文案
        /// </summary>
        [XmlElement("energy_desc")]
        public string EnergyDesc { get; set; }

        /// <summary>
        /// 能量流水id
        /// </summary>
        [XmlElement("log_id")]
        public string LogId { get; set; }

        /// <summary>
        /// OK: 领取成功 OVER_ACTIVITY_LIMITATION: 超过活动配置限制 OVER_ENERGY_APPLY_LIMITATION: 超过能量获取限制 ACTIVITY_EXPIRED: 活动过期
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 能量领取失败的原因描述
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }
    }
}
