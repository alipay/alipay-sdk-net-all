using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppCustomGrayMemberInfoDto Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppCustomGrayMemberInfoDto : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
