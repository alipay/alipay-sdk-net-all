using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyPointQueryModel : AopObject
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
