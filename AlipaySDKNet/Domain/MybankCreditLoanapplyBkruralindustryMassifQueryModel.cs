using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyBkruralindustryMassifQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyBkruralindustryMassifQueryModel : AopObject
    {
        /// <summary>
        /// 流水id
        /// </summary>
        [XmlElement("business_no")]
        public string BusinessNo { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 用户2088
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
