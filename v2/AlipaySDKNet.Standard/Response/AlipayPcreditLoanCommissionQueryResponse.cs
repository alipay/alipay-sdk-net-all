using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanCommissionQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanCommissionQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动期间累计佣金金额
        /// </summary>
        [XmlElement("activity_commission_amt")]
        public string ActivityCommissionAmt { get; set; }

        /// <summary>
        /// 活动期间累计佣金排名
        /// </summary>
        [XmlElement("activity_commission_rank")]
        public string ActivityCommissionRank { get; set; }

        /// <summary>
        /// 是否活动期内
        /// </summary>
        [XmlElement("activity_period")]
        public bool ActivityPeriod { get; set; }

        /// <summary>
        /// 企业ID，如居然之家、红星美凯龙等
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
