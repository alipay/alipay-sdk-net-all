using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUnitedopencouponPrizechooseQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignUnitedopencouponPrizechooseQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否绑定手机号。（只有活动规则上配置要求绑定手机号且当前用户未绑定手机号情况下该字段才会返回false，其余情况下不返回或者返回为空（null）
        /// </summary>
        [XmlElement("bind_phone")]
        public bool BindPhone { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("camp_end_time")]
        public string CampEndTime { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("camp_start_time")]
        public string CampStartTime { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 用户支付宝登录号（脱敏）
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 奖品选择列表
        /// </summary>
        [XmlArray("prize_category_details")]
        [XmlArrayItem("open_prize_category_detail")]
        public List<OpenPrizeCategoryDetail> PrizeCategoryDetails { get; set; }

        /// <summary>
        /// 是否实名认证（只有活动规则上配置需要验证实名，且当前用户不满足该规则时才会返回false，其余情况默认不返回或者返回为null）
        /// </summary>
        [XmlElement("real_name_auth")]
        public bool RealNameAuth { get; set; }

        /// <summary>
        /// 是否是风险用户
        /// </summary>
        [XmlElement("risk_user")]
        public bool RiskUser { get; set; }
    }
}
