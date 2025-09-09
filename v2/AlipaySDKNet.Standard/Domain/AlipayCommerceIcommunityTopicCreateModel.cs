using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIcommunityTopicCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIcommunityTopicCreateModel : AopObject
    {
        /// <summary>
        /// 当前话题创建外部请求的唯一标识
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }

        /// <summary>
        /// 创建话题的头像，该头像用于C端用户选择时展示
        /// </summary>
        [XmlElement("topic_avatar")]
        public string TopicAvatar { get; set; }

        /// <summary>
        /// 话题背景图资源id,可以通过 alipay.open.file.upload 获取图片文件资源id
        /// </summary>
        [XmlElement("topic_background_image")]
        public string TopicBackgroundImage { get; set; }

        /// <summary>
        /// 用于调用方的业务场景
        /// </summary>
        [XmlElement("topic_create_biz_scene")]
        public string TopicCreateBizScene { get; set; }

        /// <summary>
        /// 话题创建人id
        /// </summary>
        [XmlElement("topic_creator_id")]
        public string TopicCreatorId { get; set; }

        /// <summary>
        /// 话题内容的描述
        /// </summary>
        [XmlElement("topic_desc")]
        public string TopicDesc { get; set; }

        /// <summary>
        /// 话题关联的小组id列表
        /// </summary>
        [XmlArray("topic_link_group_ids")]
        [XmlArrayItem("string")]
        public List<string> TopicLinkGroupIds { get; set; }

        /// <summary>
        /// 话题名称
        /// </summary>
        [XmlElement("topic_name")]
        public string TopicName { get; set; }
    }
}
