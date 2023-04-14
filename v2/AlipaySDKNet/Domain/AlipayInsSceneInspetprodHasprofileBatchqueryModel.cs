using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInspetprodHasprofileBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInspetprodHasprofileBatchqueryModel : AopObject
    {
        /// <summary>
        /// 场景码-外部场景标识
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 渠道号
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用户标识List
        /// </summary>
        [XmlArray("mark_id_list")]
        [XmlArrayItem("pet_mark_id_d_t_o")]
        public List<PetMarkIdDTO> MarkIdList { get; set; }
    }
}
