using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCardExpireperiodModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCardExpireperiodModifyModel : AopObject
    {
        /// <summary>
        /// 当industry_solution_type为TIMES_CARD时使用、代表将原有的有效期延期到这个时间点
        /// </summary>
        [XmlElement("appoint_date")]
        public string AppointDate { get; set; }

        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 行业方案类型
        /// </summary>
        [XmlElement("industry_solution_type")]
        public string IndustrySolutionType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 幂等键
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 指定从第几期开始延期
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 按周延期还是按月延期
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 当industry_solution_type为PERIOD_PAY的时候并且update_type为FIXED的时候代表顺延几周或者几个月；当industry_solution_type为PERIOD_PAY的时候并且update_type为APPOINT的时候代表从第几期向后延多少天
        /// </summary>
        [XmlElement("period_value")]
        public long PeriodValue { get; set; }

        /// <summary>
        /// 延期模式
        /// </summary>
        [XmlElement("update_type")]
        public string UpdateType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
