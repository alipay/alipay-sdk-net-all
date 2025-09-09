using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamecenterEventSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamecenterEventSubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 在第三方游戏中，用户完成事件的渠道。
        /// </summary>
        [XmlElement("event_finish_channel")]
        public string EventFinishChannel { get; set; }

        /// <summary>
        /// 在第三方游戏中，用户在游戏中完成该事件的时间。
        /// </summary>
        [XmlElement("event_finish_date")]
        public string EventFinishDate { get; set; }

        /// <summary>
        /// 在第三方游戏中，用户在游戏中的事件id。
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 数据的全局唯一标识。用于幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 传入事件关联的属性集合，以map的形式传入。key为属性id，value为属性的值。
        /// </summary>
        [XmlArray("property_map")]
        [XmlArrayItem("ext_info_map")]
        public List<ExtInfoMap> PropertyMap { get; set; }
    }
}
