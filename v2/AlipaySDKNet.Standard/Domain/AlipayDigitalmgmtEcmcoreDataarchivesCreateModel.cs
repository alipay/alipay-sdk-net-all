using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtEcmcoreDataarchivesCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtEcmcoreDataarchivesCreateModel : AopObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 校验值
        /// </summary>
        [XmlElement("checksum")]
        public string Checksum { get; set; }

        /// <summary>
        /// 校验算法
        /// </summary>
        [XmlElement("checksum_type")]
        public string ChecksumType { get; set; }

        /// <summary>
        /// 数据描述
        /// </summary>
        [XmlElement("data_desc")]
        public string DataDesc { get; set; }

        /// <summary>
        /// 数据id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 归档数据包存放路径
        /// </summary>
        [XmlElement("data_path")]
        public string DataPath { get; set; }

        /// <summary>
        /// 系统编码
        /// </summary>
        [XmlElement("system_code")]
        public string SystemCode { get; set; }

        /// <summary>
        /// 系统名称
        /// </summary>
        [XmlElement("system_heading")]
        public string SystemHeading { get; set; }

        /// <summary>
        /// 单位编码
        /// </summary>
        [XmlElement("unit_code")]
        public string UnitCode { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        [XmlElement("unit_heading")]
        public string UnitHeading { get; set; }
    }
}
