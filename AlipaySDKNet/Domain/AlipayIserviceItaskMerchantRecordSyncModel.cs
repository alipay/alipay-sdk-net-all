using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceItaskMerchantRecordSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskMerchantRecordSyncModel : AopObject
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务数据主键
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 消费用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 用户信息详情
        /// </summary>
        [XmlElement("buyer_info")]
        public BuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// 内容扩展参数
        /// </summary>
        [XmlElement("content")]
        public HomeNormalApiContent Content { get; set; }

        /// <summary>
        /// 如果buyer_id是支付宝userId...
        /// </summary>
        [XmlElement("is_alipay_user")]
        public string IsAlipayUser { get; set; }

        /// <summary>
        /// 用户是否授权
        /// </summary>
        [XmlElement("is_authorize")]
        public string IsAuthorize { get; set; }

        /// <summary>
        /// 消息时间戳，毫秒级别
        /// </summary>
        [XmlElement("msg_time")]
        public string MsgTime { get; set; }

        /// <summary>
        /// 业务数据订单状态
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }
    }
}
