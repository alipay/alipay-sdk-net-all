using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeInvokeappBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeInvokeappBindModel : AopObject
    {
        /// <summary>
        /// 产品ID列表
        /// </summary>
        [XmlArray("product_id_list")]
        [XmlArrayItem("number")]
        public List<long> ProductIdList { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
