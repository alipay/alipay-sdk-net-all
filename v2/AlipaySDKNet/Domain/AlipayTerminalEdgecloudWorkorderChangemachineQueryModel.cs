using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudWorkorderChangemachineQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudWorkorderChangemachineQueryModel : AopObject
    {
        /// <summary>
        /// 设备系列列表，用于查询指定的设备系列
        /// </summary>
        [XmlArray("device_category_names")]
        [XmlArrayItem("string")]
        public List<string> DeviceCategoryNames { get; set; }

        /// <summary>
        /// 用于筛选工单完结时间的起始时间点，例如：如完结时间在A-B这个范围内，A就是当前参数。
        /// </summary>
        [XmlElement("finish_time_from_date")]
        public string FinishTimeFromDate { get; set; }

        /// <summary>
        /// 用于筛选工单完结时间的起始时间点，例如：完结时间在A-B这个范围内，B就是当前参数。
        /// </summary>
        [XmlElement("finish_time_to_date")]
        public string FinishTimeToDate { get; set; }
    }
}
