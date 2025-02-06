using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIcommunityContentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIcommunityContentCreateModel : AopObject
    {
        /// <summary>
        /// 表示接口调用来源的场景码
        /// </summary>
        [XmlElement("content_create_biz_scene")]
        public string ContentCreateBizScene { get; set; }

        /// <summary>
        /// 同步的内容所关联的蓝花火兴趣社区小组id
        /// </summary>
        [XmlArray("content_link_group_ids")]
        [XmlArrayItem("string")]
        public List<string> ContentLinkGroupIds { get; set; }

        /// <summary>
        /// 内容所关联的媒体信息，表示当前内容除文字之外的图片或视频信息
        /// </summary>
        [XmlArray("content_media_info")]
        [XmlArrayItem("icommunity_content_media_info")]
        public List<IcommunityContentMediaInfo> ContentMediaInfo { get; set; }

        /// <summary>
        /// 内容发布时的IP地址，ipv4&ipv6均支持
        /// </summary>
        [XmlElement("content_publish_ip")]
        public string ContentPublishIp { get; set; }

        /// <summary>
        /// 发布内容的文本内容，可以为空
        /// </summary>
        [XmlElement("content_text")]
        public string ContentText { get; set; }

        /// <summary>
        /// 同步内容的内容标题
        /// </summary>
        [XmlElement("content_title")]
        public string ContentTitle { get; set; }

        /// <summary>
        /// 1."TEXT"表示纯文本类型 2."PIC_TEXT"表示图文类型 3."VIDEO"表示视频类型 4."RICH_TEXT"表示富文本类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 内容发布时的位置信息，包括经纬度。地址等信息。
        /// </summary>
        [XmlElement("location_info")]
        public IcommunityContentLocationInfo LocationInfo { get; set; }

        /// <summary>
        /// 该参数用于唯一标识一篇内容，生成规则由业务方自定
        /// </summary>
        [XmlElement("out_content_id")]
        public string OutContentId { get; set; }

        /// <summary>
        /// 内容发布者所在省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 该条内容的发布时间
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 内容发布者id
        /// </summary>
        [XmlElement("publisher_id")]
        public string PublisherId { get; set; }

        /// <summary>
        /// 内容同步关联的话题唯一键列表
        /// </summary>
        [XmlArray("topic_id_list")]
        [XmlArrayItem("string")]
        public List<string> TopicIdList { get; set; }

        /// <summary>
        /// 发布内容关联的超链接列表
        /// </summary>
        [XmlArray("url_info_list")]
        [XmlArrayItem("icommunity_content_url_index")]
        public List<IcommunityContentUrlIndex> UrlInfoList { get; set; }
    }
}
