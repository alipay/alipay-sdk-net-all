using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingActivityInfo : AopObject
    {
        /// <summary>
        /// 活动结束时间，即券可领取结束时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动开始时间，即券可领取开始时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 活动状态： 草稿(INIT),已提交审核(P_AUDIT),已审核(AUDIT),待激活(WAIT_ACTIVE),激活(ACTIVE),暂停(PAUSE),已结束(FINISHED),已废弃(DISCARD)
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 券模板列表
        /// </summary>
        [XmlArray("voucher_template_list")]
        [XmlArrayItem("voucher_template")]
        public List<VoucherTemplate> VoucherTemplateList { get; set; }
    }
}
