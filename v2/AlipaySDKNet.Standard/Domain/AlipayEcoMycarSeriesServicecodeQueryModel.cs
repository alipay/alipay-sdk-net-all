using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarSeriesServicecodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarSeriesServicecodeQueryModel : AopObject
    {
        /// <summary>
        /// 车系ID
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }
    }
}
