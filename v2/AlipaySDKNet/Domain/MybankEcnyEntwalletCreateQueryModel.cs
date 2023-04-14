using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyEntwalletCreateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyEntwalletCreateQueryModel : AopObject
    {
        /// <summary>
        /// 单位证件号, 选择填写外部请求号时，字段必填
        /// </summary>
        [XmlElement("ent_cert_no")]
        public string EntCertNo { get; set; }

        /// <summary>
        /// 单位证件类型，选择填写外部请求号时，字段必填
        /// </summary>
        [XmlElement("ent_cert_type")]
        public string EntCertType { get; set; }

        /// <summary>
        /// 单位名称，选择填写外部请求号时，字段必填
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 外部请求号，外部请求号和受理流水号两者必填一项
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 受理流水号，外部请求号和受理流水号两者必填一项
        /// </summary>
        [XmlElement("process_no")]
        public string ProcessNo { get; set; }
    }
}
