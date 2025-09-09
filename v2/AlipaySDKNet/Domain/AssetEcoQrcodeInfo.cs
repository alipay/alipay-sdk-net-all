using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetEcoQrcodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetEcoQrcodeInfo : AopObject
    {
        /// <summary>
        /// 该参数是支付宝物料通码平台的码类型，由业务提供
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用于生态发空码时的幂等号字段，相同的幂等则发相同的空码
        /// </summary>
        [XmlElement("idempotent_num")]
        public string IdempotentNum { get; set; }

        /// <summary>
        /// 提供给生态ISV的码值信息
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 提供给生态isv服务商的生态码值图片链接
        /// </summary>
        [XmlElement("qrcode_img_url")]
        public string QrcodeImgUrl { get; set; }

        /// <summary>
        /// 提供给生态isv的码值链接url
        /// </summary>
        [XmlElement("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
