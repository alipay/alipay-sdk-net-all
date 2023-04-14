using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserWufufukaAliyunRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserWufufukaAliyunRefundModel : AopObject
    {
        /// <summary>
        /// 支付宝订单id+支付宝唯一+识别支付宝订单+否+支付宝url传递
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 扩展信息+不唯一+扩展性，传递额外信息+如有则传递
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 阿里云请求id+唯一+支付宝需感知并持久化+无+阿里云生成
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求时间+不唯一+无枚举+阿里云系统时间
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
