using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSendGuide Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSendGuide : AopObject
    {
        /// <summary>
        /// 领(购)券详情页链接，从支付宝公域跳转到服务商(商户)自定义领(购)券详情页。  说明： 当voucher_type=EXCHANGE_VOUCHER时，该字段必须填写。
        /// </summary>
        [XmlElement("voucher_detail_url")]
        public string VoucherDetailUrl { get; set; }
    }
}
