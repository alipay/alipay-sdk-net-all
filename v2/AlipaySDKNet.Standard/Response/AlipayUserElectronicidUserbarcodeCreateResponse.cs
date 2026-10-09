using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserElectronicidUserbarcodeCreateResponse.
    /// </summary>
    public class AlipayUserElectronicidUserbarcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 用户电子身份证码串
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }
    }
}
