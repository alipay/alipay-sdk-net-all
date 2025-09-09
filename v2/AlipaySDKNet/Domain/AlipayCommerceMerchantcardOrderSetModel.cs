using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrderSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardOrderSetModel : AopObject
    {
        /// <summary>
        /// 取消期数列表
        /// </summary>
        [XmlArray("cancel_period_list")]
        [XmlArrayItem("string")]
        public List<string> CancelPeriodList { get; set; }

        /// <summary>
        /// 售卖订单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 卡适用范围 【CANCEL】 AXF_MERCHANT_PERIOD_PAY、 AXF_MERCHANT_PERIOD_PAY_INDIRECT 【PAUSE/RECOVER】AXF_MERCHANT_PERIOD_PAY、 AXF_MERCHANT_PERIOD_PAY_INDIRECT 【UNBIND_CARD】AXF_MERCHANT_PERIOD_PAY、 AXF_MERCHANT_PERIOD_PAY_INDIRECT、AXF_MONEY_TIME_CARD、AXF_MONEY_CARD
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
