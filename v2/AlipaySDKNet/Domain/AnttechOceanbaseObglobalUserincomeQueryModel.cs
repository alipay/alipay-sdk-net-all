using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalUserincomeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalUserincomeQueryModel : AopObject
    {
        /// <summary>
        /// 云平台
        /// </summary>
        [XmlElement("cloud_provider")]
        public string CloudProvider { get; set; }

        /// <summary>
        /// 官网用户id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 海图用户id
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("platform_ids")]
        [XmlArrayItem("string")]
        public List<string> PlatformIds { get; set; }

        /// <summary>
        /// 销售渠道
        /// </summary>
        [XmlElement("sale_channel")]
        public string SaleChannel { get; set; }

        /// <summary>
        /// 年份
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }
    }
}
