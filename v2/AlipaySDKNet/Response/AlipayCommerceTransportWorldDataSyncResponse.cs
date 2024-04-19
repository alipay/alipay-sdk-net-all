using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportWorldDataSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportWorldDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 外部商户返回的原始错误码
        /// </summary>
        [XmlElement("org_error_code")]
        public string OrgErrorCode { get; set; }

        /// <summary>
        /// 外部商户返回的原始错误信息
        /// </summary>
        [XmlElement("org_error_msg")]
        public string OrgErrorMsg { get; set; }

        /// <summary>
        /// 外部商户返回的具体数据
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }
    }
}
