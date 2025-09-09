using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditBusinessPlanModifyResponse.
    /// </summary>
    public class ZhimaCreditBusinessPlanModifyResponse : AopResponse
    {
        /// <summary>
        /// 业务主单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 请求流水号，用于标示请求流水的唯一性。 仅支持字母、数字、下划线。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
