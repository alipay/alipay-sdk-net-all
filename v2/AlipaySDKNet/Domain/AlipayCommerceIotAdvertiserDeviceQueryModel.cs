using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserDeviceQueryModel : AopObject
    {
        /// <summary>
        /// 设备类型，比如qt 或 pos 当前字段已废弃(历史设计未使用)
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数据大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
