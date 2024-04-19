using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSelfActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动结束时间，即券可领取结束时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// b.alipay.com 自营销活动的活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动开始时间，即券可领取开始时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 当前状态，同商家自运营后台显示活动状态，已创建、已发布、已暂停、已结束
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
