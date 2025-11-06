using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinCourier Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinCourier : AopObject
    {
        /// <summary>
        /// 快递员姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 快递员联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
