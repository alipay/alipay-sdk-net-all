using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotPointQueryModel : AopObject
    {
        /// <summary>
        /// 外部点位ID
        /// </summary>
        [XmlElement("out_device_point_id")]
        public string OutDevicePointId { get; set; }

        /// <summary>
        /// 分页查询当前页码，默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询每页大小，默认值10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
