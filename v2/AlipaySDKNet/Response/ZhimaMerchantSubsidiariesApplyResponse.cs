using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantSubsidiariesApplyResponse.
    /// </summary>
    public class ZhimaMerchantSubsidiariesApplyResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [XmlElement("biz_error_message")]
        public string BizErrorMessage { get; set; }

        /// <summary>
        /// 工单标识
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
