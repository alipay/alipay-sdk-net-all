using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoutingPercentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RoutingPercentDTO : AopObject
    {
        /// <summary>
        /// 结束点差，闭区间
        /// </summary>
        [XmlElement("end_bps_val")]
        public long EndBpsVal { get; set; }

        /// <summary>
        /// 境内路由金额绝对值
        /// </summary>
        [XmlElement("onshore_abs_amount")]
        public TransferAmount OnshoreAbsAmount { get; set; }

        /// <summary>
        /// 路由比例
        /// </summary>
        [XmlElement("onshore_percent")]
        public string OnshorePercent { get; set; }

        /// <summary>
        /// 起始点差，开区间
        /// </summary>
        [XmlElement("start_bps_val")]
        public long StartBpsVal { get; set; }
    }
}
