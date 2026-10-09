using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantCbuorderChangeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantCbuorderChangeSyncModel : AopObject
    {
        /// <summary>
        /// 当前订单的来源方，例如收钱有奖，批发进货等
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 当前订单的数据变更内容
        /// </summary>
        [XmlElement("change_data")]
        public string ChangeData { get; set; }

        /// <summary>
        /// 变更的时间戳，毫秒
        /// </summary>
        [XmlElement("change_time")]
        public string ChangeTime { get; set; }

        /// <summary>
        /// 当前变更消息通知的订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
