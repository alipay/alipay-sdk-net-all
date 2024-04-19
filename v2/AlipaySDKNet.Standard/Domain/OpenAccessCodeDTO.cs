using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenAccessCodeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenAccessCodeDTO : AopObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("access_code")]
        public string AccessCode { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }
    }
}
