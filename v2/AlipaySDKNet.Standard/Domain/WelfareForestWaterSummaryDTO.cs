using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WelfareForestWaterSummaryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WelfareForestWaterSummaryDTO : AopObject
    {
        /// <summary>
        /// 当前浇水量可种植多少颗对应的树
        /// </summary>
        [XmlElement("plant_sum")]
        public long PlantSum { get; set; }

        /// <summary>
        /// 该公益林总共被浇水的次数
        /// </summary>
        [XmlElement("water_count")]
        public long WaterCount { get; set; }

        /// <summary>
        /// 浇水的人数，比如100人浇过水
        /// </summary>
        [XmlElement("water_people_count")]
        public long WaterPeopleCount { get; set; }

        /// <summary>
        /// 浇水总量
        /// </summary>
        [XmlElement("water_sum")]
        public long WaterSum { get; set; }
    }
}
