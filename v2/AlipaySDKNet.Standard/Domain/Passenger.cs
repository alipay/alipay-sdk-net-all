using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Passenger Data Structure.
    /// </summary>
    [Serializable]
    public class Passenger : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
