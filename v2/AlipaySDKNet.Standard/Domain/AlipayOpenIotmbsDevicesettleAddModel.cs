using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsDevicesettleAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsDevicesettleAddModel : AopObject
    {
        /// <summary>
        /// 设备所属的厂商名称
        /// </summary>
        [XmlElement("device_company_name")]
        public string DeviceCompanyName { get; set; }

        /// <summary>
        /// 设备所属物权的商户id
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 需要已经完成sn录入的设备
        /// </summary>
        [XmlArray("sns")]
        [XmlArrayItem("string")]
        public List<string> Sns { get; set; }

        /// <summary>
        /// 与产品沟通后才能使用
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用于定位业务流水问题
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
