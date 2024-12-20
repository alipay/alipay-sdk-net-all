using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementView Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementView : AopObject
    {
        /// <summary>
        /// 合同模板code带版本号
        /// </summary>
        [XmlElement("agreement_version")]
        public string AgreementVersion { get; set; }

        /// <summary>
        /// 协议类型Code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 隐私信息脱敏
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容格式
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 当前协议是否强制阅读
        /// </summary>
        [XmlElement("force_read")]
        public bool ForceRead { get; set; }

        /// <summary>
        /// 机构信息:机构Id和机构名称
        /// </summary>
        [XmlElement("fund_supplier")]
        public InstitutionVO FundSupplier { get; set; }

        /// <summary>
        /// 强读时间,单位秒, forceRead=true, 时默认5秒
        /// </summary>
        [XmlElement("mandatory_reading_time")]
        public long MandatoryReadingTime { get; set; }

        /// <summary>
        /// 协议类型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
