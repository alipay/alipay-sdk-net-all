using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotbizTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingParkinglotbizTransferModel : AopObject
    {
        /// <summary>
        /// 车场业务归属关系列表
        /// </summary>
        [XmlArray("business_isv")]
        [XmlArrayItem("business_item")]
        public List<BusinessItem> BusinessIsv { get; set; }

        /// <summary>
        /// 车场创建返回的parking_id字段
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
