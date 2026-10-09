using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserBillStatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserBillStatQueryModel : AopObject
    {
        /// <summary>
        /// 查询数据开始时间，包含此时间数据，待隐私合规改造后必填
        /// </summary>
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 消费记录来源 4000：淘宝 3008：支付宝 other：其他商家  为空则查询所有来源账单
        /// </summary>
        [XmlArray("consume_sites")]
        [XmlArrayItem("string")]
        public List<string> ConsumeSites { get; set; }

        /// <summary>
        /// 查询数据结束时间，包含此时间数据，待隐私合规改造后必填
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }
    }
}
