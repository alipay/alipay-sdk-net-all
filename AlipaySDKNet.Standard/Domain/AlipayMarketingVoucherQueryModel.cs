using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherQueryModel : AopObject
    {
        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)。通过 <a  href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.voucher.send">alipay.marketing.voucher.send(发券接口)发券后获取。
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
