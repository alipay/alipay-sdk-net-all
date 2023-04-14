using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleCustomsauthinitSubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleCustomsauthinitSubmitResponse : AopResponse
    {
        /// <summary>
        /// 客户数据授权协议书编号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// Y表示需要认证，N表示不需要
        /// </summary>
        [XmlElement("auth_required")]
        public string AuthRequired { get; set; }

        /// <summary>
        /// 报关数据认证起始日期(不包含此日期)，格式为：yyyymmdd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 报关数据认证起始日期(包含此日期)，格式为：yyyymmdd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
