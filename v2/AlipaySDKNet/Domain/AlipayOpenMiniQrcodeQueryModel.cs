using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniQrcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniQrcodeQueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数，最大为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
