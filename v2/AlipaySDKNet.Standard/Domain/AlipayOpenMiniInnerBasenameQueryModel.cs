using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerBasenameQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerBasenameQueryModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 业务小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
