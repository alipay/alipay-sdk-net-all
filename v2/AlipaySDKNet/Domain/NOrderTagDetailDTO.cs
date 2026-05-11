using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NOrderTagDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class NOrderTagDetailDTO : AopObject
    {
        /// <summary>
        /// 线圈编号，线圈的唯一外标
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("route_url")]
        public string RouteUrl { get; set; }

        /// <summary>
        /// 线圈的内标 唯一标识
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
