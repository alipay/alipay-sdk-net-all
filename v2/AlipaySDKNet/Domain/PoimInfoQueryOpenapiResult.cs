using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoimInfoQueryOpenapiResult Data Structure.
    /// </summary>
    [Serializable]
    public class PoimInfoQueryOpenapiResult : AopObject
    {
        /// <summary>
        /// 点位地址查询结果数据
        /// </summary>
        [XmlElement("area_info")]
        public PoimAddressQueryOpenapiResult AreaInfo { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("poim_id")]
        public string PoimId { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("poim_name")]
        public string PoimName { get; set; }

        /// <summary>
        /// 旅行景区ID
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }
    }
}
