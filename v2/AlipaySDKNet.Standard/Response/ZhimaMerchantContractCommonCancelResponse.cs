using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantContractCommonCancelResponse.
    /// </summary>
    public class ZhimaMerchantContractCommonCancelResponse : AopResponse
    {
        /// <summary>
        /// 业务结果返回值
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 业务结果，成功或失败
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }
    }
}
