using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestCarbondayQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestCarbondayQueryResponse : AopResponse
    {
        /// <summary>
        /// 日账单数据
        /// </summary>
        [XmlArray("day_trans_list")]
        [XmlArrayItem("carbon_trans")]
        public List<CarbonTrans> DayTransList { get; set; }

        /// <summary>
        /// 是否开通森林
        /// </summary>
        [XmlElement("forest_open")]
        public bool ForestOpen { get; set; }

        /// <summary>
        /// 当前数据年份
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }
    }
}
