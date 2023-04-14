using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniPublicRelationBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPublicRelationBindModel : AopObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 生活号ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
