using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyExtraParams Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyExtraParams : AopObject
    {
        /// <summary>
        /// IdentifierForVendor，在iOS系统中常被用来唯一标识设备
        /// </summary>
        [XmlElement("idfa")]
        public string Idfa { get; set; }

        /// <summary>
        /// 国际移动设备识别码
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 国际移动用户识别码
        /// </summary>
        [XmlElement("imsi")]
        public string Imsi { get; set; }

        /// <summary>
        /// 匿名设备标识符
        /// </summary>
        [XmlElement("oaid")]
        public string Oaid { get; set; }

        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("umid")]
        public string Umid { get; set; }

        /// <summary>
        /// UTDID，APP 级别的设备标识 ID
        /// </summary>
        [XmlElement("utdid")]
        public string Utdid { get; set; }
    }
}
