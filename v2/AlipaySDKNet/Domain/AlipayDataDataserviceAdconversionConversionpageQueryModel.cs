using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdconversionConversionpageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdconversionConversionpageQueryModel : AopObject
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
