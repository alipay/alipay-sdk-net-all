using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAssistantMsgCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAssistantMsgCreateModel : AopObject
    {
        /// <summary>
        /// 自定义活动类型的消息内容，对应biz_type 为 activity_recommend 时必须传相关内容
        /// </summary>
        [XmlElement("activity_content")]
        public ActivityAssistantMsgContentVO ActivityContent { get; set; }

        /// <summary>
        /// 权益推荐小助手内容，对应biz_type 为 benefit_recommend 时必须传相关内容
        /// </summary>
        [XmlElement("benefit_content")]
        public BenefitAssistantMsgContentVO BenefitContent { get; set; }

        /// <summary>
        /// 小助手类型，目前支持 activity_recommend (自定义活动)、benefit_recommend（权益推荐）
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 消息发布时间
        /// </summary>
        [XmlElement("gmt_published")]
        public string GmtPublished { get; set; }

        /// <summary>
        /// 群组id列表，创建群组时对应的一个群组id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 消息名称，b侧展示用，不在c侧群内透出
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
