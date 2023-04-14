using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestCarbonmonthQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestCarbonmonthQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否开通森林
        /// </summary>
        [XmlElement("forest_open")]
        public bool ForestOpen { get; set; }

        /// <summary>
        /// 月账单数据
        /// </summary>
        [XmlArray("month_trans_list")]
        [XmlArrayItem("carbon_trans")]
        public List<CarbonTrans> MonthTransList { get; set; }

        /// <summary>
        /// 对应数据的年份
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }
    }
}
