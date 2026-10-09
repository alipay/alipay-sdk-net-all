using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SnsTradeDataResult Data Structure.
    /// </summary>
    [Serializable]
    public class SnsTradeDataResult : AopObject
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 用于返回截止当前日期的动销数量
        /// </summary>
        [XmlElement("trd_count")]
        public string TrdCount { get; set; }
    }
}
