using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpCopyrightInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpCopyrightInfo : AopObject
    {
        /// <summary>
        /// 著作权人
        /// </summary>
        [XmlElement("copyright_holder")]
        public string CopyrightHolder { get; set; }

        /// <summary>
        /// 创作完成日期
        /// </summary>
        [XmlElement("czwcrq")]
        public string Czwcrq { get; set; }

        /// <summary>
        /// 分类号
        /// </summary>
        [XmlElement("flh")]
        public string Flh { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [XmlElement("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 公告日期
        /// </summary>
        [XmlElement("proclamation_date")]
        public string ProclamationDate { get; set; }

        /// <summary>
        /// 公告类型
        /// </summary>
        [XmlElement("proclamation_type")]
        public string ProclamationType { get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 登记号
        /// </summary>
        [XmlElement("register_number")]
        public string RegisterNumber { get; set; }

        /// <summary>
        /// 软件著作权登记号
        /// </summary>
        [XmlElement("rjzzqdjh")]
        public string Rjzzqdjh { get; set; }

        /// <summary>
        /// 首次发表日期
        /// </summary>
        [XmlElement("scfbrq")]
        public string Scfbrq { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [XmlElement("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 软件简称
        /// </summary>
        [XmlElement("software_abbreviation_name")]
        public string SoftwareAbbreviationName { get; set; }

        /// <summary>
        /// 软件全称
        /// </summary>
        [XmlElement("software_full_name")]
        public string SoftwareFullName { get; set; }

        /// <summary>
        /// 软件名称
        /// </summary>
        [XmlElement("software_name")]
        public string SoftwareName { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version_number")]
        public string VersionNumber { get; set; }

        /// <summary>
        /// 作品名称
        /// </summary>
        [XmlElement("work_name")]
        public string WorkName { get; set; }

        /// <summary>
        /// 作品类别
        /// </summary>
        [XmlElement("zplb")]
        public string Zplb { get; set; }
    }
}
