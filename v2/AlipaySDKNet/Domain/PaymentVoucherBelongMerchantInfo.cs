using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherBelongMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherBelongMerchantInfo : AopObject
    {
        /// <summary>
        /// 商户支付宝id，默认品牌名和品牌logo将从该商户信息中获取
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户id类型。  若传入的类型为直连商户则必须签约当面付且当前接口调用者与商户存在代运营关系 当类型为SMID时表示为某个间连商户配券，但是券的归属者属于当前接口调用人。 枚举值 SMID 间连商户 PID 直连商户
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
