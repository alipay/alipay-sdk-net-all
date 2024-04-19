using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AbilityResourceConsume Data Structure.
    /// </summary>
    [Serializable]
    public class AbilityResourceConsume : AopObject
    {
        /// <summary>
        /// 业务标记
        /// </summary>
        [XmlArray("ability_resource_biz_mark")]
        [XmlArrayItem("ability_resource_biz_mark")]
        public List<AbilityResourceBizMark> AbilityResourceBizMark { get; set; }

        /// <summary>
        /// isv提供的资源消耗code,是单次上报的全局唯一code
        /// </summary>
        [XmlElement("consume_code")]
        public string ConsumeCode { get; set; }

        /// <summary>
        /// 资源计量的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// isv资源被使用的时候,商户绑定的appid
        /// </summary>
        [XmlElement("m_app_id")]
        public string MAppId { get; set; }

        /// <summary>
        /// 计量值,当前时间段类消耗了多少
        /// </summary>
        [XmlElement("record_val")]
        public string RecordVal { get; set; }

        /// <summary>
        /// 资源计量的开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
