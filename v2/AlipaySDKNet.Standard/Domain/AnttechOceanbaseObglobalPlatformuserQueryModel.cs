using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalPlatformuserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalPlatformuserQueryModel : AopObject
    {
        /// <summary>
        /// 客户编码
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 云平台
        /// </summary>
        [XmlElement("cloud_provider")]
        public string CloudProvider { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 官网用户ID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 销售渠道
        /// </summary>
        [XmlElement("sale_channel")]
        public string SaleChannel { get; set; }
    }
}
