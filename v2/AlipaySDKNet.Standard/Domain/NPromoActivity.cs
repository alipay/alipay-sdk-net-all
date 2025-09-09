using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NPromoActivity Data Structure.
    /// </summary>
    [Serializable]
    public class NPromoActivity : AopObject
    {
        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("activity_desc")]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// 活动设备sn
        /// </summary>
        [XmlElement("activity_dvc_sn")]
        public string ActivityDvcSn { get; set; }

        /// <summary>
        /// 用户活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型（0元先享任务）
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 活动创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 活动生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 活动终止时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 跳过日期
        /// </summary>
        [XmlArray("ignore_date")]
        [XmlArrayItem("date")]
        public List<string> IgnoreDate { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子活动列表
        /// </summary>
        [XmlArray("sub_activity_lists")]
        [XmlArrayItem("n_promo_sub_activity")]
        public List<NPromoSubActivity> SubActivityLists { get; set; }
    }
}
