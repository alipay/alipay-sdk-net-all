using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalCrmmsgSendResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalCrmmsgSendResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("biz_error_msg")]
        public string BizErrorMsg { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
