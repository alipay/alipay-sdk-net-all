using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandProductionChangeSyncResponse.
    /// </summary>
    public class AntMerchantExpandProductionChangeSyncResponse : AopResponse
    {
        /// <summary>
        /// errorCode
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 项目单号（供应商维度）
        /// </summary>
        [XmlElement("project_no")]
        public string ProjectNo { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
