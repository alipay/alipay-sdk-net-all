using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTailpaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTailpaymentQueryModel : AopObject
    {
        /// <summary>
        /// 预约品必填； 非预约品，不用填
        /// </summary>
        [XmlElement("main_booking_order_id")]
        public string MainBookingOrderId { get; set; }

        /// <summary>
        /// 原始订单id
        /// </summary>
        [XmlElement("main_order_id")]
        public string MainOrderId { get; set; }

        /// <summary>
        /// 分页页码，不传默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，不传默认为10，最大50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
