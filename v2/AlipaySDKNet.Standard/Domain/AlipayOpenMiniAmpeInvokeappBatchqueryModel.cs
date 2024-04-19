using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeInvokeappBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeInvokeappBatchqueryModel : AopObject
    {
        /// <summary>
        /// 场景码，申请后平台分配
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
