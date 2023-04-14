using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerclientinfoQueryModel : AopObject
    {
        /// <summary>
        /// 端创建时提供的bundle_id
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }
    }
}
