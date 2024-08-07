using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeadsCarInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsCarInfo : AopObject
    {
        /// <summary>
        /// 车id
        /// </summary>
        [XmlElement("car_id")]
        public string CarId { get; set; }

        /// <summary>
        /// 数据文本
        /// </summary>
        [XmlElement("car_name")]
        public string CarName { get; set; }

        /// <summary>
        /// 车类型
        /// </summary>
        [XmlElement("car_type")]
        public string CarType { get; set; }
    }
}
