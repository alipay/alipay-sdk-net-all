using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotPaymentCustomInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IotPaymentCustomInfo : AopObject
    {
        /// <summary>
        /// 金额类展示内容，可在实际金额前置附加单位或其他自定义前置字段，title为餐补，amountShow 为￥5.00， 即展示内容为 餐补 ￥5.00
        /// </summary>
        [XmlElement("amount_show")]
        public string AmountShow { get; set; }

        /// <summary>
        /// 用于支付结果页展示，该字段为左侧标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
