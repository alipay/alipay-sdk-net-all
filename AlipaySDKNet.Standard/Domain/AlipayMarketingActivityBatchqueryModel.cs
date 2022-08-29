using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityBatchqueryModel : AopObject
    {
        /// <summary>
        /// 活动状态 。 ACTIVE:活动已激活，表示活动已经生效，等到活动开始(publish_start_time)之后用户就可以参与活动。 PAUSE:活动已暂停，表示商户临时暂停该活动，该状态下用户不能参与活动。
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商户接入模式。
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 商户PID,默认为当前接口调用商户。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 分页查询页码。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
