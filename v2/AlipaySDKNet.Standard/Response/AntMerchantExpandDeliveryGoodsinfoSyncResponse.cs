using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandDeliveryGoodsinfoSyncResponse.
    /// </summary>
    public class AntMerchantExpandDeliveryGoodsinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 配送指令id，参考已有获取配送指令接口。
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
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
