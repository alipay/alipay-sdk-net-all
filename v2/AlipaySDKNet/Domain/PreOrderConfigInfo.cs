using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PreOrderConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PreOrderConfigInfo : AopObject
    {
        /// <summary>
        /// OPEN表示打开点餐服务 CLOSED表示关闭点餐服务，不传表示不做更新
        /// </summary>
        [XmlElement("pre_order_status")]
        public string PreOrderStatus { get; set; }

        /// <summary>
        /// 最早可提前预订时间，格式: hh:mm，如：00:15，表示15分钟；02:00，表示2个小时。不设置默认为提前5分钟，00:05。
        /// </summary>
        [XmlElement("time_before")]
        public string TimeBefore { get; set; }

        /// <summary>
        /// 自提时段配置列表,按照周规则设置
        /// </summary>
        [XmlArray("time_period_config_list")]
        [XmlArrayItem("time_period_config")]
        public List<TimePeriodConfig> TimePeriodConfigList { get; set; }
    }
}
