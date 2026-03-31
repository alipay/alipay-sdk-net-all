using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserInfoDemo Data Structure.
    /// </summary>
    [Serializable]
    public class UserInfoDemo : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("second_level")]
        public RainyComplexTypesTheFirstTwo SecondLevel { get; set; }
    }
}
