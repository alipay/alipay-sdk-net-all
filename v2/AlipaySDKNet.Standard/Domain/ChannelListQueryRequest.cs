using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelListQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelListQueryRequest : AopObject
    {
        /// <summary>
        /// 当前页，默认1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数量，默认100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
