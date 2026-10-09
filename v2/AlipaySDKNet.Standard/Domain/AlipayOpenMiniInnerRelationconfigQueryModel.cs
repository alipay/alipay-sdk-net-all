using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerRelationconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerRelationconfigQueryModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
