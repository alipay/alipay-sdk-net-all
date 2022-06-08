using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAsaingameScheduleAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAsaingameScheduleAddModel : AopObject
    {
        /// <summary>
        /// 如果要加入到某一天，则必传。 如果新建则非必传
        /// </summary>
        [XmlElement("daily_schedule_id")]
        public string DailyScheduleId { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 详细门店数据，json格式
        /// </summary>
        [XmlElement("step_data")]
        public string StepData { get; set; }
    }
}
