using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdpublicCreativetoolQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdpublicCreativetoolQueryModel : AopObject
    {
        /// <summary>
        /// 分页参数，第几页
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 分页参数，每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 根据生活号ID或名称模糊查询
        /// </summary>
        [XmlElement("search_key")]
        public string SearchKey { get; set; }
    }
}
