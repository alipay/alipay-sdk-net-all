using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationPackageItem Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationPackageItem : AopObject
    {
        /// <summary>
        /// 主要指标
        /// </summary>
        [XmlElement("indicators")]
        public string Indicators { get; set; }

        /// <summary>
        /// 标品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标品id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 履约方编码
        /// </summary>
        [XmlElement("vendor_code")]
        public string VendorCode { get; set; }
    }
}
