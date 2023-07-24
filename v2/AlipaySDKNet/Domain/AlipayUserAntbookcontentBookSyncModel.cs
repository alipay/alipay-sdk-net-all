using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntbookcontentBookSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntbookcontentBookSyncModel : AopObject
    {
        /// <summary>
        /// 作者
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 书籍是否已完结
        /// </summary>
        [XmlElement("book_finished")]
        public bool BookFinished { get; set; }

        /// <summary>
        /// 书籍是否免费
        /// </summary>
        [XmlElement("book_free")]
        public bool BookFree { get; set; }

        /// <summary>
        /// 外部书籍ID，可唯一标识一本书
        /// </summary>
        [XmlElement("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// 书籍简介，限制500个字符
        /// </summary>
        [XmlElement("brief")]
        public string Brief { get; set; }

        /// <summary>
        /// 书籍类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 版权类型
        /// </summary>
        [XmlElement("copyright_type")]
        public string CopyrightType { get; set; }

        /// <summary>
        /// 封面原图
        /// </summary>
        [XmlElement("cover_url")]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 书籍创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 目前人群标签
        /// </summary>
        [XmlArray("crowd_tag_list")]
        [XmlArrayItem("string")]
        public List<string> CrowdTagList { get; set; }

        /// <summary>
        /// 书籍名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// ADD：新增书籍信息 UPDATE：书籍信息变更
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 书籍热度信息，有则传入
        /// </summary>
        [XmlElement("popularity_info")]
        public BookPopularityInfo PopularityInfo { get; set; }

        /// <summary>
        /// 书籍价格信息，收费书籍必填
        /// </summary>
        [XmlElement("price_info")]
        public BookPriceInfo PriceInfo { get; set; }

        /// <summary>
        /// 专辑营销活动信息，有则传入
        /// </summary>
        [XmlElement("promo_info")]
        public BookPromoInfo PromoInfo { get; set; }

        /// <summary>
        /// 推荐理由
        /// </summary>
        [XmlElement("recommend_reason")]
        public string RecommendReason { get; set; }

        /// <summary>
        /// 目标场景列表
        /// </summary>
        [XmlArray("scene_list")]
        [XmlArrayItem("string")]
        public List<string> SceneList { get; set; }

        /// <summary>
        /// 章节数量
        /// </summary>
        [XmlElement("sum_chapters")]
        public long SumChapters { get; set; }

        /// <summary>
        /// 书籍总字数
        /// </summary>
        [XmlElement("sum_words")]
        public long SumWords { get; set; }

        /// <summary>
        /// 书籍标签列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 书籍更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
