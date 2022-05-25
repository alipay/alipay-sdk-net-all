using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAsiangamesHotelstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAsiangamesHotelstatusQueryModel : AopObject
    {
        /// <summary>
        /// 当前页码，不传默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据量，正整数，不传默认为100,最大为200
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
