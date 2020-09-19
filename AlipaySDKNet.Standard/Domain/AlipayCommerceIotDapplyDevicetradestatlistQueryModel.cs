using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyDevicetradestatlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyDevicetradestatlistQueryModel : AopObject
    {
        /// <summary>
        /// 分页起始偏移
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询范围截止日期
        /// </summary>
        [XmlElement("stat_end")]
        public string StatEnd { get; set; }

        /// <summary>
        /// 查询范围起始值
        /// </summary>
        [XmlElement("stat_start")]
        public string StatStart { get; set; }
    }
}
