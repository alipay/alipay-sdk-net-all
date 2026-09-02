using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcTollFeeTollStatsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EtcTollFeeTollStatsDTO : AopObject
    {
        /// <summary>
        /// 平均通行费(元）
        /// </summary>
        [XmlElement("avg")]
        public string Avg { get; set; }

        /// <summary>
        /// 最小通行费(元）
        /// </summary>
        [XmlElement("max")]
        public string Max { get; set; }

        /// <summary>
        /// 中位数通行费(元）
        /// </summary>
        [XmlElement("median")]
        public string Median { get; set; }

        /// <summary>
        /// 最小通行费(元）
        /// </summary>
        [XmlElement("min")]
        public string Min { get; set; }

        /// <summary>
        /// TOP three通行费分布 当前字段已废弃(废弃top3,和业务沟通只取top1)
        /// </summary>
        [XmlArray("top_three")]
        [XmlArrayItem("etc_toll_fee_top_three_d_t_o")]
        public List<EtcTollFeeTopThreeDTO> TopThree { get; set; }

        /// <summary>
        /// 众数通行费,单位(元)
        /// </summary>
        [XmlElement("trip_fee")]
        public string TripFee { get; set; }
    }
}
