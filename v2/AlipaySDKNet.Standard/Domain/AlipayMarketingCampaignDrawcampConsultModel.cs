using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDrawcampConsultModel : AopObject
    {
        /// <summary>
        /// 营销海豚活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 扩展字段Map，格式为{"key","value"}，其中key需要与支付宝营销平台约定
        /// </summary>
        [XmlElement("ext_params")]
        public ConsultExtParams ExtParams { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 指定过滤奖品id列表，最多支持10个，多个奖品用英文逗号分割，为空时咨询活动下所有的奖品
        /// </summary>
        [XmlElement("prize_id_list")]
        public string PrizeIdList { get; set; }

        /// <summary>
        /// 系统来源，接入请和支付宝营销平台开发or产品同学申请
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
