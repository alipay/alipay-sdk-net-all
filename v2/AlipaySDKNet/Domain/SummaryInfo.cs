using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SummaryInfo : AopObject
    {
        /// <summary>
        /// 创建渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 生活号id
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 生活号名称
        /// </summary>
        [XmlElement("public_name")]
        public string PublicName { get; set; }

        /// <summary>
        /// 上架：ON_LINE,下架：OFF_LINE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
