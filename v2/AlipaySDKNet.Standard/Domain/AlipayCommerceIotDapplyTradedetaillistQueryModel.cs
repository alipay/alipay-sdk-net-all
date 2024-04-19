using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyTradedetaillistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyTradedetaillistQueryModel : AopObject
    {
        /// <summary>
        /// 起始偏移位置
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// 一页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询截止时间
        /// </summary>
        [XmlElement("stat_end")]
        public string StatEnd { get; set; }

        /// <summary>
        /// 查询起止日期
        /// </summary>
        [XmlElement("stat_start")]
        public string StatStart { get; set; }
    }
}
