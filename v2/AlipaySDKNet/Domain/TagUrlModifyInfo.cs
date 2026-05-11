using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagUrlModifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TagUrlModifyInfo : AopObject
    {
        /// <summary>
        /// 链接地址
        /// </summary>
        [XmlElement("route_url")]
        public string RouteUrl { get; set; }

        /// <summary>
        /// 线圈id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 线圈sn
        /// </summary>
        [XmlElement("tag_sn")]
        public string TagSn { get; set; }
    }
}
