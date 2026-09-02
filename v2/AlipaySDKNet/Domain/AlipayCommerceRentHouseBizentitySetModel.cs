using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentHouseBizentitySetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentHouseBizentitySetModel : AopObject
    {
        /// <summary>
        /// 房源item/小区community/商家merchant等
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("field_value_pairs")]
        public List<FieldValuePairs> Fields { get; set; }

        /// <summary>
        /// 房源id/小区id,从房源提报接口取值
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
