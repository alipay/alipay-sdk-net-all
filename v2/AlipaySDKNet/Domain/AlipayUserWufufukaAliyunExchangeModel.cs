using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserWufufukaAliyunExchangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserWufufukaAliyunExchangeModel : AopObject
    {
        /// <summary>
        /// 支付宝订单id+支付宝获取订单+无+url传递
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 阿里云商品id，支付宝用于校验订单-商品关系，url传递后阿里云获取
        /// </summary>
        [XmlElement("aliyun_item_id")]
        public long AliyunItemId { get; set; }

        /// <summary>
        /// 扩展信息+否+扩展+无+接入方传递
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 请求id+唯一+支付宝更新状态持久化+无+业务方生成
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 扣减时间 + 无 + 支付宝记录 + 无+阿里云系统调用时间+无
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 支付宝用户id+否+业务方理解+无+支付宝传递
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
