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
        /// OpenId是某个用户在某个应用下的唯一用户标识， 对于同一个用户，不同应用拿到的OpenId是不同的，而且对于同一个应用，不同用户的OpenId是唯一的
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

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
