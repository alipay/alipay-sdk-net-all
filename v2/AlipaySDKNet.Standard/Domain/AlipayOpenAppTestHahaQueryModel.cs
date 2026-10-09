using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestHahaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestHahaQueryModel : AopObject
    {
        /// <summary>
        /// 2088
        /// </summary>
        [XmlElement("test_one")]
        public string TestOne { get; set; }

        /// <summary>
        /// 复杂类型
        /// </summary>
        [XmlElement("test_three")]
        public LogisticsAccountStatusDTO TestThree { get; set; }

        /// <summary>
        /// 2088000
        /// </summary>
        [XmlElement("test_two")]
        public string TestTwo { get; set; }
    }
}
