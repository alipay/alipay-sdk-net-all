using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxBasicInfo : AopObject
    {
        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 搜索直达名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 搜索直达配置状态，INITIAL-初始/ONLINE-已上架/EXPIRE-已失效/OFFLINE-已下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
