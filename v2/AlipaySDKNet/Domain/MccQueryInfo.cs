using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MccQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MccQueryInfo : AopObject
    {
        /// <summary>
        /// 是否特殊行业
        /// </summary>
        [XmlElement("is_special")]
        public bool IsSpecial { get; set; }

        /// <summary>
        /// 一级类目code
        /// </summary>
        [XmlElement("mcc_level_1")]
        public string MccLevel1 { get; set; }

        /// <summary>
        /// 商户一级类目名称
        /// </summary>
        [XmlElement("mcc_level_1_name")]
        public string MccLevel1Name { get; set; }

        /// <summary>
        /// 二级类目code
        /// </summary>
        [XmlElement("mcc_level_2")]
        public string MccLevel2 { get; set; }

        /// <summary>
        /// 二级类目名称
        /// </summary>
        [XmlElement("mcc_level_2_name")]
        public string MccLevel2Name { get; set; }

        /// <summary>
        /// 特殊行业需要上传的资质
        /// </summary>
        [XmlElement("mcc_requirements")]
        public string MccRequirements { get; set; }

        /// <summary>
        /// 是否需要特殊资质
        /// </summary>
        [XmlElement("special_qual_required")]
        public bool SpecialQualRequired { get; set; }
    }
}
