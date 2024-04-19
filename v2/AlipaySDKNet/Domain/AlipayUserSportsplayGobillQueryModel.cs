using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSportsplayGobillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportsplayGobillQueryModel : AopObject
    {
        /// <summary>
        /// 路线场景ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 路线id
        /// </summary>
        [XmlElement("path_id")]
        public string PathId { get; set; }
    }
}
