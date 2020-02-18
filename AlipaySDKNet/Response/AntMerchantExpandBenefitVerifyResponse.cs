using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandBenefitVerifyResponse.
    /// </summary>
    public class AntMerchantExpandBenefitVerifyResponse : AopResponse
    {
        /// <summary>
        /// 扩展的业务信息
        /// </summary>
        [XmlElement("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("detail_msg")]
        public string DetailMsg { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 核销结果 true/false
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
