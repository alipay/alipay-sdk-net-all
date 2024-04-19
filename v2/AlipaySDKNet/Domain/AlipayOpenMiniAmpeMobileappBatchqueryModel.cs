using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeMobileappBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeMobileappBatchqueryModel : AopObject
    {
        /// <summary>
        /// 场景码，申请后平台分配
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
