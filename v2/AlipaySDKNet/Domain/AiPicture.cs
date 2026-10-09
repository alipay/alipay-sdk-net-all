using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AiPicture Data Structure.
    /// </summary>
    [Serializable]
    public class AiPicture : AopObject
    {
        /// <summary>
        /// 支付宝AIGC生成的订单ID
        /// </summary>
        [XmlElement("aigc_order_id")]
        public string AigcOrderId { get; set; }

        /// <summary>
        /// 多媒体图片ID
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 安全状态
        /// </summary>
        [XmlElement("sec_status")]
        public string SecStatus { get; set; }
    }
}
