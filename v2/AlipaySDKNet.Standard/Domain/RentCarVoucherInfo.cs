using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarVoucherInfo : AopObject
    {
        /// <summary>
        /// 租车券的金额，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 商户出资金额，特指交易的本商家出资，单位分
        /// </summary>
        [XmlElement("merchant_contribute")]
        public long MerchantContribute { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其他出资，非交易本商家，可能是支付宝，可能是品牌商，或者其他方，也可能是他们的一起，单位分
        /// </summary>
        [XmlElement("other_contribute")]
        public long OtherContribute { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 租车券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
