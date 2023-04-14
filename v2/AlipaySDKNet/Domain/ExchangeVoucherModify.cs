using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExchangeVoucherModify Data Structure.
    /// </summary>
    [Serializable]
    public class ExchangeVoucherModify : AopObject
    {
        /// <summary>
        /// 领（购）券详情页链接，从支付宝公域跳转到服务商（商户）自定义领（购）券详情页。
        /// </summary>
        [XmlElement("voucher_detail_url")]
        public string VoucherDetailUrl { get; set; }

        /// <summary>
        /// 对消费者展示的券（商品）名称。
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }
    }
}
