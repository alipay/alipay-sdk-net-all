using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelTag Data Structure.
    /// </summary>
    [Serializable]
    public class HotelTag : AopObject
    {
        /// <summary>
        /// 是否支持早餐
        /// </summary>
        [XmlElement("support_breakfast")]
        public bool SupportBreakfast { get; set; }

        /// <summary>
        /// 是否支持免费取消
        /// </summary>
        [XmlElement("support_free_cancel")]
        public bool SupportFreeCancel { get; set; }

        /// <summary>
        /// 是否支持预付
        /// </summary>
        [XmlElement("support_prepay")]
        public bool SupportPrepay { get; set; }

        /// <summary>
        /// 是否支持预付发票
        /// </summary>
        [XmlElement("support_prepay_invoice")]
        public bool SupportPrepayInvoice { get; set; }

        /// <summary>
        /// 是否支持到店付
        /// </summary>
        [XmlElement("support_self_pay")]
        public bool SupportSelfPay { get; set; }

        /// <summary>
        /// 是否支持专票
        /// </summary>
        [XmlElement("support_special_invoice")]
        public bool SupportSpecialInvoice { get; set; }
    }
}
