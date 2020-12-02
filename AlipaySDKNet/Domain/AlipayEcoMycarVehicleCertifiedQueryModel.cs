using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehicleCertifiedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarVehicleCertifiedQueryModel : AopObject
    {
        /// <summary>
        /// 车牌列表
        /// </summary>
        [XmlArray("plate_no_list")]
        [XmlArrayItem("string")]
        public List<string> PlateNoList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
