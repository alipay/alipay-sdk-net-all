using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardOrderSyncModel : AopObject
    {
        /// <summary>
        /// 实际激活的时间
        /// </summary>
        [XmlElement("activation_time")]
        public string ActivationTime { get; set; }

        /// <summary>
        /// 开卡/退卡的时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 业务类型开卡和激活时传open，退（卡）款时传refund
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 所开会员卡ID，取开卡时id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 固定枚举值，荣耀-HONOR,小米-XIAOMI,OPPO-OPPO
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 客户系统中的用户id,每个用户唯一,由客户系统生成并传入
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 客户订单流水号，值唯一，由客户系统生成并传入
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 客户系统下单时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 非必传，但是手机号和UID必须二选一，在客户系统汇总，用户下单开通对应服务的手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 商家pid,商家侧传入2088格式
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 非必传，但是手机号和UID必须二选一，用户在支付宝侧的UID账号（UID必须存在）
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 用户user_id，唯一映射用户uid，用于唯一标识用户
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
