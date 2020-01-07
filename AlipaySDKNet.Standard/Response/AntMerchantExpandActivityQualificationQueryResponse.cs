using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandActivityQualificationQueryResponse.
    /// </summary>
    public class AntMerchantExpandActivityQualificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户无资格时的具体原因
        /// </summary>
        [XmlElement("detail_msg")]
        public string DetailMsg { get; set; }

        /// <summary>
        /// 用户无资格时的错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否有资格
        /// </summary>
        [XmlElement("has_qualification")]
        public string HasQualification { get; set; }
    }
}
