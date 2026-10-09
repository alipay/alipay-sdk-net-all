using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherListQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 券模板 id，可通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.voucher.templatelist.query">alipay.marketing.voucher.templatelist.query</a>(查询券模板列表)接口查询获取。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
