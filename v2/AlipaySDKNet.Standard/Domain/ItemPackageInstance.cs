using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPackageInstance Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPackageInstance : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("commodity_code")]
        public string CommodityCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 结束时间，为13位的UNIX时间戳
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商品规格编码
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 资源包规格实例ID
        /// </summary>
        [XmlElement("spec_instance_id")]
        public string SpecInstanceId { get; set; }

        /// <summary>
        /// 商品规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 开始时间，为13位的UNIX时间戳
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
