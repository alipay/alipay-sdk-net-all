using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoSceneQueryResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoSceneQueryResponse : AopResponse
    {
        /// <summary>
        /// 场景信息
        /// </summary>
        [XmlElement("scene_list")]
        public MpcSceneQueryInfo SceneList { get; set; }
    }
}
