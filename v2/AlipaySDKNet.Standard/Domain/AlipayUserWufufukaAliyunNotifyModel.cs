using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserWufufukaAliyunNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserWufufukaAliyunNotifyModel : AopObject
    {
        /// <summary>
        /// 阿里云配置的活动id,支付宝基于此id进行库存修改
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 阿里云业务id，阿里云分配并传递，支付宝进行校验
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 阿里云商品id，支付宝理解并基于此修改库存
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 请求时间，请求中默认携带
        /// </summary>
        [XmlElement("notice_time")]
        public string NoticeTime { get; set; }

        /// <summary>
        /// 通知类型，此接口中，支付宝侧仅感知SESSSION_INVENTORY_TO_ZERO单个值
        /// </summary>
        [XmlElement("notice_type")]
        public string NoticeType { get; set; }

        /// <summary>
        /// 请求id，阿里云唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 阿里云场次id，支付宝理解并修改库存
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 阿里云子业务id
        /// </summary>
        [XmlElement("sub_biz_id")]
        public string SubBizId { get; set; }
    }
}
