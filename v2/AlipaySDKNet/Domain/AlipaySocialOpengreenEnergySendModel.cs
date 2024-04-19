using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialOpengreenEnergySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialOpengreenEnergySendModel : AopObject
    {
        /// <summary>
        /// 用户绿色行为时间戳，可选，如果不填，默认为请求接口时间，可用于识别用户行为时间，并根据时间生成对应的能量球
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 业务唯一单号，描述用户每次绿色行为的标识，同一行为应保障bizNo相同，尽量不带有 "_" 符号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户产生绿色行为的小程序id
        /// </summary>
        [XmlElement("energy_app_id")]
        public string EnergyAppId { get; set; }

        /// <summary>
        /// 能量扩展信息，仅特殊能量场景需要传入，对接时可咨询森林技术同学
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("energy_ext_request")]
        public List<EnergyExtRequest> ExtInfo { get; set; }

        /// <summary>
        /// 绿色行为描述
        /// </summary>
        [XmlArray("green_actions")]
        [XmlArrayItem("green_action")]
        public List<GreenAction> GreenActions { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家的支付宝id，用于描述用户是在哪一个商家中进行的绿色行为，该信息需在绿色开放平台后台进行注册签约（签约注册请与技术、业务同学沟通）
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 请与对接方业务同学或森林业务同学确认source信息
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
