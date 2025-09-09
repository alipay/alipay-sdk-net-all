using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialCollectioncontentGroupinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialCollectioncontentGroupinfoModifyModel : AopObject
    {
        /// <summary>
        /// 背景图
        /// </summary>
        [XmlElement("banner_url")]
        public string BannerUrl { get; set; }

        /// <summary>
        /// 一级分类
        /// </summary>
        [XmlElement("collection_category")]
        public string CollectionCategory { get; set; }

        /// <summary>
        /// 合集ID，对应优酷的视频资源ID
        /// </summary>
        [XmlElement("collection_id")]
        public string CollectionId { get; set; }

        /// <summary>
        /// 合集/短剧对应的名称
        /// </summary>
        [XmlElement("collection_name")]
        public string CollectionName { get; set; }

        /// <summary>
        /// 二级分类
        /// </summary>
        [XmlElement("collection_second_category")]
        public string CollectionSecondCategory { get; set; }

        /// <summary>
        /// 是否已完结； 已完结：1 未完结：2
        /// </summary>
        [XmlElement("completed_status")]
        public string CompletedStatus { get; set; }

        /// <summary>
        /// 短视频素材来源
        /// </summary>
        [XmlElement("content_source")]
        public string ContentSource { get; set; }

        /// <summary>
        /// 总集数，代表合集/短剧的总集数
        /// </summary>
        [XmlElement("episodes_count")]
        public string EpisodesCount { get; set; }

        /// <summary>
        /// 更新到第几集
        /// </summary>
        [XmlElement("episodes_number")]
        public string EpisodesNumber { get; set; }

        /// <summary>
        /// 请求类型：1: 新增短素材 2 编辑短素材 3 删除短素材 4 编辑合集内容
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 短十字箴言
        /// </summary>
        [XmlElement("short_title")]
        public string ShortTitle { get; set; }
    }
}
