using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignAppleActivityConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignAppleActivityConsultModel : AopObject
    {
        /// <summary>
        /// 活动id 活动的唯一标识 接口人根据具体活动分配
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 扩展字段 活动扩展字段 调用方根据不同活动传递
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 调用方平台用户ID 记录平台用户ID和支付宝ID对应关系 调用方平台提供
        /// </summary>
        [XmlElement("out_biz_value")]
        public string OutBizValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
