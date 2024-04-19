using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalCrmworkstatusQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalCrmworkstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// VALIDATION_FAIL
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [XmlElement("biz_error_msg")]
        public string BizErrorMsg { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// suspended：停用 un_suspended：非停用  null：未查询到相关信息或者查询失败
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
