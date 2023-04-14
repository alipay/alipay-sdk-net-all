using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSendGuideModify Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSendGuideModify : AopObject
    {
        /// <summary>
        /// 领（购）券详情页链接，从支付宝公域跳转到服务商（商户）自定义领(购)券详情页。说明：当 voucher_type=EXCHANGE_VOUCHER 时，该字段可修改，其他不允许修改。
        /// </summary>
        [XmlElement("voucher_detail_url")]
        public string VoucherDetailUrl { get; set; }
    }
}
