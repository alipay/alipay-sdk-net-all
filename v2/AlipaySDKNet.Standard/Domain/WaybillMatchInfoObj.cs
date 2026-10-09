using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WaybillMatchInfoObj Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillMatchInfoObj : AopObject
    {
        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 匹配类型
        /// </summary>
        [XmlElement("match_type")]
        public string MatchType { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
