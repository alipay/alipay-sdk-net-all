using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniUserInfo : AopObject
    {
        /// <summary>
        /// 使用人联系方式，脱敏展示
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 使用人姓名，脱敏返回
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
