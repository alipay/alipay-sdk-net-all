using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookingLimit Data Structure.
    /// </summary>
    [Serializable]
    public class BookingLimit : AopObject
    {
        /// <summary>
        /// 餐饮政策
        /// </summary>
        [XmlElement("breakfast_policy")]
        public string BreakfastPolicy { get; set; }

        /// <summary>
        /// 儿童政策
        /// </summary>
        [XmlElement("children_policy")]
        public string ChildrenPolicy { get; set; }

        /// <summary>
        /// 是否可以养宠物
        /// </summary>
        [XmlElement("pet_info")]
        public string PetInfo { get; set; }

        /// <summary>
        /// 可订时间范围
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
