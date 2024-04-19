using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantSubsidiariesCloseResponse.
    /// </summary>
    public class ZhimaMerchantSubsidiariesCloseResponse : AopResponse
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
        /// 工单审核备注
        /// </summary>
        [XmlElement("order_memo")]
        public string OrderMemo { get; set; }

        /// <summary>
        /// 工单标识，业务成功时返回工单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 工单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
