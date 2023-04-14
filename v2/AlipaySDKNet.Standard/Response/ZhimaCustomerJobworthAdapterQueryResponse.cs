using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthAdapterQueryResponse.
    /// </summary>
    public class ZhimaCustomerJobworthAdapterQueryResponse : AopResponse
    {
        /// <summary>
        /// 匹配度
        /// </summary>
        [XmlElement("adapter_score")]
        public string AdapterScore { get; set; }

        /// <summary>
        /// 业务编码
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
