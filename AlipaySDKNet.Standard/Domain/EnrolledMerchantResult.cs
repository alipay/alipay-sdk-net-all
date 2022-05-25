using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnrolledMerchantResult Data Structure.
    /// </summary>
    [Serializable]
    public class EnrolledMerchantResult : AopObject
    {
        /// <summary>
        /// 商家维度错误码, MERCHANT_NO_EXIST, MERCHANT_NO_ENROLL, MERCHANT_UNDER_RISK_CONTROL
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 商家维度错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 商户pid，唯一标识，最大10个
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
