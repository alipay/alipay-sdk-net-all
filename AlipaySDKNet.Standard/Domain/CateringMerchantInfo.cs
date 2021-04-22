using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateringMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CateringMerchantInfo : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 商家logo（上传logo图片返回的material_id）
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 直连商户id。除排队之外，特殊可选
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 间联商户。除排队之外，特殊可选，pid smid 必有一个。银行ISV将商户入驻得到的sub_merchant_id，受理商户唯一标识。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
