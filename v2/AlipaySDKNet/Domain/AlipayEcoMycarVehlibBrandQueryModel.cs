using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehlibBrandQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarVehlibBrandQueryModel : AopObject
    {
        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，1~100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
