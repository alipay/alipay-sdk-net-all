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
        /// 商家logo（上传logo图片返回的material_key）。平台小程序必填；模板或自研小程序选填，不填官方会取小程序Logo 请使用此文档集的图片上传接口上传获取的ID （alipay.merchant.item.file.upload）
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 品牌在支付宝商家平台的PID。除排队场景外，PID/SMID必填一个。
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 品牌在支付宝商家平台的入驻得到的sub_merchant_id，受理商户唯一标识。除排队场景外，PID/SMID必填一个。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
