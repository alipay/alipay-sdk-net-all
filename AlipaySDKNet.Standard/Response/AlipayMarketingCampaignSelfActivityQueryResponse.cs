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
        /// b.alipay.com 自营销活动的活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 当前状态，同商家自运营后台显示活动状态，已创建、已发布、已暂停、已结束
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 券模板列表
        /// </summary>
        [XmlArray("voucher_template_list")]
        [XmlArrayItem("voucher_template")]
        public List<VoucherTemplate> VoucherTemplateList { get; set; }
    }
}
