using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGameopenpromoGamecenteractivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGameopenpromoGamecenteractivityQueryModel : AopObject
    {
        /// <summary>
        /// 平台活动id，通过线下沟通提前约定好活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 从小游戏链接中直接获取到的渠道参数
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
