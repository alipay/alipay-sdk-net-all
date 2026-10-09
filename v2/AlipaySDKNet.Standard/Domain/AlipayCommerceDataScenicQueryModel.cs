using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataScenicQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataScenicQueryModel : AopObject
    {
        /// <summary>
        /// 表示当前页， 不传默认第一页
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数量，不传默认200， 最大不超过1000
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 景区小程序APPID。 未加白名单的服务商一定要传该值，否则查询不到结果
        /// </summary>
        [XmlElement("scenic_app_id")]
        public string ScenicAppId { get; set; }
    }
}
