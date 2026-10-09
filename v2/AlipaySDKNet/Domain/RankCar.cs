using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RankCar Data Structure.
    /// </summary>
    [Serializable]
    public class RankCar : AopObject
    {
        /// <summary>
        /// 车型id
        /// </summary>
        [XmlElement("car_id")]
        public string CarId { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [XmlElement("car_name")]
        public string CarName { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_name")]
        public string DataName { get; set; }

        /// <summary>
        /// 数据值
        /// </summary>
        [XmlElement("data_value")]
        public string DataValue { get; set; }
    }
}
