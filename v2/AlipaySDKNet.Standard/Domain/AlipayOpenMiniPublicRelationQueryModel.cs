using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniPublicRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPublicRelationQueryModel : AopObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
