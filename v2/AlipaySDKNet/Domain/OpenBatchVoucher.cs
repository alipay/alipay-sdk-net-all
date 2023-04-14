using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenBatchVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class OpenBatchVoucher : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 支付宝用户ID(映射的openId)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 发送对象
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
