using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicTrafficUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicTrafficUserInfo : AopObject
    {
        /// <summary>
        /// 姓名，isv请做脱敏处理。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话，isv请做脱敏处理。
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
