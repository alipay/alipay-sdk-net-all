using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkloanAuthorderInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkloanAuthorderInitializeModel : AopObject
    {
        /// <summary>
        /// 授信准入类型
        /// </summary>
        [XmlElement("access_type")]
        public string AccessType { get; set; }

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

        /// <summary>
        /// 企业法人证件号
        /// </summary>
        [XmlElement("operator_cert_no")]
        public string OperatorCertNo { get; set; }
    }
}
