using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkloanAuthorderSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkloanAuthorderSubmitModel : AopObject
    {
        /// <summary>
        /// 贷种类型
        /// </summary>
        [XmlElement("loan_type")]
        public string LoanType { get; set; }

        /// <summary>
        /// 商户自身的授信单号，需保证其唯一性
        /// </summary>
        [XmlElement("merchant_biz_no")]
        public string MerchantBizNo { get; set; }
    }
}
