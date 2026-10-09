using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenModuleData Data Structure.
    /// </summary>
    [Serializable]
    public class OpenModuleData : AopObject
    {
        /// <summary>
        /// 概要结果描述
        /// </summary>
        [XmlElement("red_code")]
        public string RedCode { get; set; }

        /// <summary>
        /// 支付结果描述
        /// </summary>
        [XmlElement("summary")]
        public OpenPayResultSummary Summary { get; set; }
    }
}
