using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentItem Data Structure.
    /// </summary>
    [Serializable]
    public class ContentItem : AopObject
    {
        /// <summary>
        /// 作者粉丝数
        /// </summary>
        [XmlElement("author_fans")]
        public long AuthorFans { get; set; }

        /// <summary>
        /// 作者ID
        /// </summary>
        [XmlElement("author_id")]
        public string AuthorId { get; set; }

        /// <summary>
        /// 作者评级
        /// </summary>
        [XmlElement("author_level")]
        public string AuthorLevel { get; set; }

        /// <summary>
        /// 作者名
        /// </summary>
        [XmlElement("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// 内容的类目，内容不同级类目之间用$##$分隔，且自左向右类目层级逐渐细化。类目值搜索全部传名称，举例如“美食分享$##$中餐$##$川菜”。某一段为空时直接传空字符串，如第二段为空， 则传“美食分享$##$$##$川菜”。如果有多个类目，多个类目之间用,分割。
        /// </summary>
        [XmlElement("cate")]
        public string Cate { get; set; }

        /// <summary>
        /// 内容类目的层级数。cate_cnt必须等于len(cate.split('$##$'))，用于校验cate数据。所有内容的分类体系应该一致，即对于所有商品来说，cate_cnt应该相同
        /// </summary>
        [XmlElement("cate_cnt")]
        public long CateCnt { get; set; }

        /// <summary>
        /// 内容累计收藏数
        /// </summary>
        [XmlElement("collect_cnt")]
        public string CollectCnt { get; set; }

        /// <summary>
        /// 所属话题id
        /// </summary>
        [XmlElement("collection")]
        public string Collection { get; set; }

        /// <summary>
        /// 内容累计评论次数
        /// </summary>
        [XmlElement("comment_cnt")]
        public string CommentCnt { get; set; }

        /// <summary>
        /// 内容描述，用于搜索
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容失效时间
        /// </summary>
        [XmlElement("copyright_end")]
        public string CopyrightEnd { get; set; }

        /// <summary>
        /// 内容生效时间
        /// </summary>
        [XmlElement("copyright_start")]
        public string CopyrightStart { get; set; }

        /// <summary>
        /// 创建时间 单位为毫秒
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 详情页中图片的数量
        /// </summary>
        [XmlElement("detail_pic_num")]
        public long DetailPicNum { get; set; }

        /// <summary>
        /// 支付宝小程序的详情页面
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 内容过期时间戳，精确到毫秒
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 内容的唯一ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 视频或文章的关键描述词
        /// </summary>
        [XmlArray("key_word")]
        [XmlArrayItem("string")]
        public List<string> KeyWord { get; set; }

        /// <summary>
        /// 地域tag
        /// </summary>
        [XmlElement("location_tag")]
        public string LocationTag { get; set; }

        /// <summary>
        /// 商品归属的小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 可选 图片url，如果多张图，头图放在前面，使用$##$链接多个url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品累计点赞次数
        /// </summary>
        [XmlElement("praise_cnt")]
        public long PraiseCnt { get; set; }

        /// <summary>
        /// 精确到毫秒，如1520327038000
        /// </summary>
        [XmlElement("pub_time")]
        public string PubTime { get; set; }

        /// <summary>
        /// 8.8
        /// </summary>
        [XmlElement("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// 相关商品id，多个使用$##$来区分
        /// </summary>
        [XmlElement("related_goods_ids")]
        public string RelatedGoodsIds { get; set; }

        /// <summary>
        /// 内容累计分享次数
        /// </summary>
        [XmlElement("share_cnt")]
        public long ShareCnt { get; set; }

        /// <summary>
        /// 内容来源类型，如自然up主
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 状态 1为有效 0为无效
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 内容标签，如首页展示标签“时政热点”，“财经热点”。多值示例：“时政热点,时财经"
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 内容标题，用于搜索
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 所属话题tag
        /// </summary>
        [XmlElement("topic_tag")]
        public string TopicTag { get; set; }

        /// <summary>
        /// 内容的类别，如short_doc/video
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 内容信息更新时间戳，精确到毫秒，如1520327038000
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 视频时长 单位为毫秒
        /// </summary>
        [XmlElement("video_duration")]
        public string VideoDuration { get; set; }

        /// <summary>
        /// 可选 视频url。如果有多个，使用$##$链接多个url
        /// </summary>
        [XmlElement("video_url")]
        public string VideoUrl { get; set; }
    }
}
