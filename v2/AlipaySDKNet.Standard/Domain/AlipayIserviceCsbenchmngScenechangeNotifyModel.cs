using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsbenchmngScenechangeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsbenchmngScenechangeNotifyModel : AopObject
    {
        /// <summary>
        /// ServiceSceneBasicVO
        /// </summary>
        [XmlArray("service_scene_list")]
        [XmlArrayItem("service_scene_basic_v_o")]
        public List<ServiceSceneBasicVO> ServiceSceneList { get; set; }
    }
}
