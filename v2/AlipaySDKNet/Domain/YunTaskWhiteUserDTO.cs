using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YunTaskWhiteUserDTO Data Structure.
    /// </summary>
    [Serializable]
    public class YunTaskWhiteUserDTO : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 白名单手机号
        /// </summary>
        [XmlElement("white_phone")]
        public string WhitePhone { get; set; }

        /// <summary>
        /// 白名单类型
        /// </summary>
        [XmlElement("white_type")]
        public string WhiteType { get; set; }
    }
}
