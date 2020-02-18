using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandDeliveryLogisticsSyncResponse.
    /// </summary>
    public class AntMerchantExpandDeliveryLogisticsSyncResponse : AopResponse
    {
        /// <summary>
        /// 配送指令
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 业务处理结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
