using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectSupplementCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectSupplementCreateModel : AopObject
    {
        /// <summary>
        /// logo图片，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [XmlElement("logo_key")]
        public string LogoKey { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
