using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityNoticePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityNoticePublishModel : AopObject
    {
        /// <summary>
        /// 产品类型： OWNER_CARD 电子业主卡
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 城市code，例如 杭州市 330100000000
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 社区code，例如 清波门社区
        /// </summary>
        [XmlElement("community")]
        public string Community { get; set; }

        /// <summary>
        /// 区县code，例如 上城区 330102000000
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 详情页链接
        /// </summary>
        [XmlElement("detail_link_url")]
        public string DetailLinkUrl { get; set; }

        /// <summary>
        /// 过期时间，默认2099-12-31
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 是否置顶1-是，0-否
        /// </summary>
        [XmlElement("is_top")]
        public long IsTop { get; set; }

        /// <summary>
        /// 列表页链接
        /// </summary>
        [XmlElement("list_link_url")]
        public string ListLinkUrl { get; set; }

        /// <summary>
        /// 公告类型 公示公告：NOTICE 投票类型：VOTE 问卷调查：QUESTIONNAIRE
        /// </summary>
        [XmlElement("notice_type")]
        public string NoticeType { get; set; }

        /// <summary>
        /// 外部小区号
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }

        /// <summary>
        /// 外部公告id
        /// </summary>
        [XmlElement("out_notice_id")]
        public string OutNoticeId { get; set; }

        /// <summary>
        /// 省code
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 发布单位：如机构、街道、社区、业委会、物业
        /// </summary>
        [XmlElement("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// 街道code，例如 清波街道 330102001000
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }

        /// <summary>
        /// 产品子类型： HANGZHOU_OWNER_CARD 杭州房管局电子业主卡
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 子公告类型
        /// </summary>
        [XmlElement("sub_notice_type")]
        public string SubNoticeType { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
