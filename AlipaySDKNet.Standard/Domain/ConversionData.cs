using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConversionData Data Structure.
    /// </summary>
    [Serializable]
    public class ConversionData : AopObject
    {
        /// <summary>
        /// 留资流水号，用于source=XLIGHT
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 转化事件ID
        /// </summary>
        [XmlElement("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化时间，UTC 时间戳，单位：秒
        /// </summary>
        [XmlElement("conversion_time")]
        public long ConversionTime { get; set; }

        /// <summary>
        /// 转化事件类型
        /// </summary>
        [XmlElement("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 创意ID
        /// </summary>
        [XmlElement("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 单元ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 商家标志
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 留资数据列表，用于source=OTHER
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("conversion_property")]
        public List<ConversionProperty> PropertyList { get; set; }

        /// <summary>
        /// 留资来源：XLIGHT-灯火留资；OTHER-其它
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 转化用户唯一标识
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
