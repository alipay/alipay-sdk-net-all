using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityOwnercardmsgSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityOwnercardmsgSyncModel : AopObject
    {
        /// <summary>
        /// 产品类型： OWNER_CARD 电子业主卡
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 社区code
        /// </summary>
        [XmlElement("community")]
        public string Community { get; set; }

        /// <summary>
        /// 社区底座小区短名
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 区县code
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 过期时间，默认2099-12-31
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 消息id，若不为空则表示更新
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否置顶1-是，0-否
        /// </summary>
        [XmlElement("is_top")]
        public string IsTop { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 外部消息id
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 省code
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 发布单位：如机构、街道、社区、业委会、物业
        /// </summary>
        [XmlElement("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// 服务类型： NOTICE 通知公告， VOTE 投票表决， FUNDING 经营性收支， QUESTIONNAIRE 问卷调查
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 状态 ONLINE：在线 INVALID：失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 街道code
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }

        /// <summary>
        /// 产品子类型： HANGZHOU_OWNER_CARD 杭州房管局电子业主卡
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 个性化模板json格式： NORMAL 通用类型 空 VOTE 投票表决 投票率 voteRate  （必填，数据类型：数字） 投票率数据日期 voteDate（ 必填，数据类型：日期，日期格式：yyyy-MM-dd HH:mm:ss）； 投票截止日期 voteEndDate（ 必填，数据类型：日期，日期格式：yyyy-MM-dd HH:mm:ss）  FUNDING 经营性收支 月份 month  (必填，数据类型：数字) 结余 balance (必填，数据类型：数字) 收入 income (必填，数据类型：数字) 支出 expenditure (必填，数据类型：数字)
        /// </summary>
        [XmlElement("template_content")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// 模板类型： NORMAL通用类型 VOTE 投票类型 FUNDING 经营性收支类型
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
