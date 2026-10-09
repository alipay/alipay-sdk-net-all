using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserWufufukaAliyunFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserWufufukaAliyunFinishModel : AopObject
    {
        /// <summary>
        /// 支付宝订单id，url传递获取，支付宝根据该id查询对应订单
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 阿里云订单id，支付宝落库，用于订单详情页url拼接及问题排查
        /// </summary>
        [XmlElement("aliyun_order_id")]
        public string AliyunOrderId { get; set; }

        /// <summary>
        /// 扩展信息，扩展性预留，用于传递其他信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 请求id，单笔唯一，阿里云生成，支付宝根据id跟库中数据比较保证唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求时间，支付宝落库
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 更新目标状态，支付宝只感知SUCCESS状态，其他会认为参数异常
        /// </summary>
        [XmlElement("target_status")]
        public string TargetStatus { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
