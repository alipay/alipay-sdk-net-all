using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoSceneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoSceneQueryModel : AopObject
    {
        /// <summary>
        /// 查询页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 查询条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 坑位id
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
