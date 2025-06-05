using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBenefitaccountAccountCreateModel : AopObject
    {
        /// <summary>
        /// 授权信息
        /// </summary>
        [XmlElement("authorization_info")]
        public FsAuthorizationInfoForm AuthorizationInfo { get; set; }

        /// <summary>
        /// 业务订单号-用于户号幂等，一个户号一个bizNo业务订单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 权益账户生效时间
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 权益账户失效时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 出资方信息
        /// </summary>
        [XmlArray("fund_infos")]
        [XmlArrayItem("fs_fund_info_form")]
        public List<FsFundInfoForm> FundInfos { get; set; }

        /// <summary>
        /// 出资关系组
        /// </summary>
        [XmlArray("fund_relation_groups")]
        [XmlArrayItem("fs_fund_relation_group_form")]
        public List<FsFundRelationGroupForm> FundRelationGroups { get; set; }

        /// <summary>
        /// 支付宝回调通知的url
        /// </summary>
        [XmlElement("mnotify_url")]
        public string MnotifyUrl { get; set; }

        /// <summary>
        /// 权益账户的账户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 创建人对应的支付宝userId
        /// </summary>
        [XmlElement("publisher_user_id")]
        public string PublisherUserId { get; set; }
    }
}
