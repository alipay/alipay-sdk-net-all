using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntbooksAlbumSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntbooksAlbumSyncModel : AopObject
    {
        /// <summary>
        /// 专辑整体时长，单位秒
        /// </summary>
        [XmlElement("album_duration")]
        public long AlbumDuration { get; set; }

        /// <summary>
        /// 专辑是否已完结。
        /// </summary>
        [XmlElement("album_finished")]
        public bool AlbumFinished { get; set; }

        /// <summary>
        /// 专辑是否免费，免费专辑下所有声音应都可免费畅听。
        /// </summary>
        [XmlElement("album_free")]
        public bool AlbumFree { get; set; }

        /// <summary>
        /// 专辑ID，在合作方侧应唯一对应一个专辑。
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }

        /// <summary>
        /// 专辑主播人，有则必填。
        /// </summary>
        [XmlElement("announcer")]
        public string Announcer { get; set; }

        /// <summary>
        /// 专辑作者名，有则必填。
        /// </summary>
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 专辑简介信息，对C端用户展示。
        /// </summary>
        [XmlElement("brief")]
        public string Brief { get; set; }

        /// <summary>
        /// 专辑所属类目名称列表，层级关系使用-隔开
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("string")]
        public List<string> CategoryList { get; set; }

        /// <summary>
        /// 版权类型，有则传入。
        /// </summary>
        [XmlElement("copyright_type")]
        public string CopyrightType { get; set; }

        /// <summary>
        /// 专辑原图URL地址
        /// </summary>
        [XmlElement("cover_url")]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 专辑封面大图
        /// </summary>
        [XmlElement("cover_url_big")]
        public string CoverUrlBig { get; set; }

        /// <summary>
        /// 专辑封面中图
        /// </summary>
        [XmlElement("cover_url_middle")]
        public string CoverUrlMiddle { get; set; }

        /// <summary>
        /// 专辑封面小图
        /// </summary>
        [XmlElement("cover_url_small")]
        public string CoverUrlSmall { get; set; }

        /// <summary>
        /// 专辑面世时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 拓展信息List，内部为AlbumExtInfo对象，其中包含两个字段key及value，以此实现业务上的Map<String, String>
        /// </summary>
        [XmlArray("ext_info_list")]
        [XmlArrayItem("album_ext_info")]
        public List<AlbumExtInfo> ExtInfoList { get; set; }

        /// <summary>
        /// 专辑名称，用于对C端用户展示。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// ADD：新增专辑录入 UPDATE：专辑（包含声音）的信息变更 DELETE：专辑下架
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 专辑热度信息，有则传入
        /// </summary>
        [XmlElement("popularity_info")]
        public AlbumPopularityInfo PopularityInfo { get; set; }

        /// <summary>
        /// 专辑价格信息，收费专辑必填
        /// </summary>
        [XmlElement("price_info")]
        public AlbumPriceInfo PriceInfo { get; set; }

        /// <summary>
        /// 专辑营销活动信息，有则传入
        /// </summary>
        [XmlElement("promo_info")]
        public AlbumPromoInfo PromoInfo { get; set; }

        /// <summary>
        /// 专辑推荐理由，有则填入。
        /// </summary>
        [XmlElement("recommend_reason")]
        public string RecommendReason { get; set; }

        /// <summary>
        /// 专辑内声音列表
        /// </summary>
        [XmlArray("sound_list")]
        [XmlArrayItem("album_sound_info")]
        public List<AlbumSoundInfo> SoundList { get; set; }

        /// <summary>
        /// 专辑标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 目标人群标签
        /// </summary>
        [XmlArray("target_crowd_tags")]
        [XmlArrayItem("string")]
        public List<string> TargetCrowdTags { get; set; }

        /// <summary>
        /// 专辑在合作方侧最近更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
