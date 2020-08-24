using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeProductBatchqueryModel : AopObject
    {
        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
