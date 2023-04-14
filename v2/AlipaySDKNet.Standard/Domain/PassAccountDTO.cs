using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PassAccountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PassAccountDTO : AopObject
    {
        /// <summary>
        /// 账号名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
