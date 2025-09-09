using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountBalanceremindlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountBalanceremindlistQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，固定传：QUERY_PLAN_LIST
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 被监控账户
        /// </summary>
        [XmlElement("monitor_user_id")]
        public string MonitorUserId { get; set; }

        /// <summary>
        /// 被监控账户
        /// </summary>
        [XmlElement("monitor_user_open_id")]
        public string MonitorUserOpenId { get; set; }

        /// <summary>
        /// 产品码，固定传：BALANCE_REMIND
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 接入方的业务场景，如示例值：ETC代扣场景
        /// </summary>
        [XmlElement("third_biz_scene")]
        public string ThirdBizScene { get; set; }
    }
}
