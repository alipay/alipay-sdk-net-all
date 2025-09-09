using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingNewhouseLayoutQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingNewhouseLayoutQueryModel : AopObject
    {
        /// <summary>
        /// 楼盘id
        /// </summary>
        [XmlElement("estate_project_id")]
        public string EstateProjectId { get; set; }

        /// <summary>
        /// 外部户型id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
