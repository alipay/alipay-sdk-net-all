using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthJobdataAddResponse.
    /// </summary>
    public class ZhimaCustomerJobworthJobdataAddResponse : AopResponse
    {
        /// <summary>
        /// 受理台单号，用来调用工作证受理台
        /// </summary>
        [XmlElement("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 业务中文结果信息
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }

        /// <summary>
        /// 职得工作证跳转小程序链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
