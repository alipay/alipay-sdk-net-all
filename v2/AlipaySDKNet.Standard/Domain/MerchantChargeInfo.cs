using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantChargeInfo : AopObject
    {
        /// <summary>
        /// certify_id
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// FAIL_NOT_CHARGE：该单据不符合计费规则，不进行计费；CHARGE：该单据符合计费规则，进行计费。
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 若查询的certifyId无效（数据库中没有记录），在响应的结构体里的errorCode返回INVALID_CERTIFY_ID。
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }
    }
}
