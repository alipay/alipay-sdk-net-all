using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityNoticeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityNoticeSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 市，6位code
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 社区code
        /// </summary>
        [XmlElement("community")]
        public string Community { get; set; }

        /// <summary>
        /// 支付宝小区编码，由支付宝分配
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 区县，6位code
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 详情链接
        /// </summary>
        [XmlElement("detail_link_url")]
        public string DetailLinkUrl { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        [XmlElement("is_top")]
        public bool IsTop { get; set; }

        /// <summary>
        /// 通知公告类型- NOTICE　小区公告 PRIVATE_NOTICE　用户通用通知 JIAOFEI_NOTICE 缴费通知 INVOICE_NOTICE 开票通知 REMIND_NOTICE 催缴通知 VOTE 投票表决 FUNDING 经营性收支 QUESTIONNAIRE 问卷调查
        /// </summary>
        [XmlElement("notice_type")]
        public string NoticeType { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 外部小区id
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }

        /// <summary>
        /// 省，6位code
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 发布单位：如机构、街道、社区、业委会、物业
        /// </summary>
        [XmlElement("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 街道code
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
