using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChceckReport Data Structure.
    /// </summary>
    [Serializable]
    public class ChceckReport : AopObject
    {
        /// <summary>
        /// 出报告的时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 报告的PDF地址
        /// </summary>
        [XmlElement("pdf_url")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("test_name")]
        public string TestName { get; set; }

        /// <summary>
        /// 履约方的项目编码
        /// </summary>
        [XmlElement("vendor_code")]
        public string VendorCode { get; set; }
    }
}
