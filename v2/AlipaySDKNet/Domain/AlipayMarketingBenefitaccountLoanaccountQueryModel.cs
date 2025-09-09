using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBenefitaccountLoanaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBenefitaccountLoanaccountQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 检索结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 分页中末尾订单号
        /// </summary>
        [XmlElement("last_order_id")]
        public string LastOrderId { get; set; }

        /// <summary>
        /// 单页展示数量
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 支付宝侧uid
        /// </summary>
        [XmlElement("principal_user_id")]
        public string PrincipalUserId { get; set; }

        /// <summary>
        /// 开始检索时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
