using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditBillrepayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditBillrepayQueryModel : AopObject
    {
        /// <summary>
        /// 时间范围查询的结束时间，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 企业Id，企业入驻企业码时自动分配的用于唯一标识的编号
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 没有还款查询时间范围限定时，借款申请的商户单号必传
        /// </summary>
        [XmlElement("loan_out_biz_no")]
        public string LoanOutBizNo { get; set; }

        /// <summary>
        /// 时间范围查询的开始时间，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
