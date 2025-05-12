using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantMultiendserviceprodQrcodeMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantMultiendserviceprodQrcodeMatchModel : AopObject
    {
        /// <summary>
        /// 二维码码值
        /// </summary>
        [XmlElement("qrcode_value")]
        public string QrcodeValue { get; set; }
    }
}
