using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlateNoCertDto Data Structure.
    /// </summary>
    [Serializable]
    public class PlateNoCertDto : AopObject
    {
        /// <summary>
        /// true，false
        /// </summary>
        [XmlElement("cert_result")]
        public bool CertResult { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }
    }
}
