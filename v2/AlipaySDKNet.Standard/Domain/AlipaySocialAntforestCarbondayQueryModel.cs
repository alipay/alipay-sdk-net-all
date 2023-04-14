using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestCarbondayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestCarbondayQueryModel : AopObject
    {
        /// <summary>
        /// 碳账户绿色场景类型，类型为字符串数组。
        /// </summary>
        [XmlArray("carbon_type")]
        [XmlArrayItem("string")]
        public List<string> CarbonType { get; set; }

        /// <summary>
        /// 日期（选填），不输入时间，查询最近30天数据， 输入时间，查询指定日期数据
        /// </summary>
        [XmlElement("day")]
        public string Day { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
