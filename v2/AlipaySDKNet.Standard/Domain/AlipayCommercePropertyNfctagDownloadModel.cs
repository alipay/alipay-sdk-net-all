using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyNfctagDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyNfctagDownloadModel : AopObject
    {
        /// <summary>
        /// 业务类型 巡检：PATROL(默认) 
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 宿主小程序id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 线圈数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
