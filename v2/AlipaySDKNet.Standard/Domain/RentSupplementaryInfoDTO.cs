using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSupplementaryInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentSupplementaryInfoDTO : AopObject
    {
        /// <summary>
        /// 用户实际下单时间
        /// </summary>
        [XmlElement("real_create_time")]
        public string RealCreateTime { get; set; }
    }
}
