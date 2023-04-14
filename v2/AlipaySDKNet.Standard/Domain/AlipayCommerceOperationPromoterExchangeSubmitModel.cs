using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoterExchangeSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoterExchangeSubmitModel : AopObject
    {
        /// <summary>
        /// 交兑换订单时作为外部订单号,用于防重复提交
        /// </summary>
        [XmlElement("exchange_token")]
        public string ExchangeToken { get; set; }

        /// <summary>
        /// 奖品code,唯一标识
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 需要绑定的门店对映的pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 积分数
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }

        /// <summary>
        /// 任务code，唯一标识
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 店员id，点击提交的收银员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
