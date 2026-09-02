using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehlibModelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarVehlibModelQueryModel : AopObject
    {
        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 车系ID可从车型库车系查询接口返回的series_id获取
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }
    }
}
