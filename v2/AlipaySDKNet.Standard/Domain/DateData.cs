using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DateData Data Structure.
    /// </summary>
    [Serializable]
    public class DateData : AopObject
    {
        /// <summary>
        /// 数据日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 多个指标的数据
        /// </summary>
        [XmlArray("indicator_data_list")]
        [XmlArrayItem("indicator_data")]
        public List<IndicatorData> IndicatorDataList { get; set; }
    }
}
