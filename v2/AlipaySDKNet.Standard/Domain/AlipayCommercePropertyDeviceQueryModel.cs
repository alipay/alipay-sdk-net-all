using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyDeviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyDeviceQueryModel : AopObject
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 一页查询多少条数据
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
