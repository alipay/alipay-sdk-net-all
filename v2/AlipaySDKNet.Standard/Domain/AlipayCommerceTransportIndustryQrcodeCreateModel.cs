using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIndustryQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIndustryQrcodeCreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("ebike_charge_qrcode_param")]
        public List<EbikeChargeQrcodeParam> DetailList { get; set; }

        /// <summary>
        /// code：只需要生成码值 all：生成码值和图片
        /// </summary>
        [XmlElement("qr_code_type")]
        public string QrCodeType { get; set; }

        /// <summary>
        /// 是否使用短链接（不传则默认值为true）。 值为true时，会转成短链接生成二维码图片
        /// </summary>
        [XmlElement("use_short_url")]
        public bool UseShortUrl { get; set; }
    }
}
