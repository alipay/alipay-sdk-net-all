using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSystemSignFile Data Structure.
    /// </summary>
    [Serializable]
    public class CaSystemSignFile : AopObject
    {
        /// <summary>
        /// 签署区域信息（包括印模信息）
        /// </summary>
        [XmlArray("ca_system_sign_area_list")]
        [XmlArrayItem("ca_system_sign_area")]
        public List<CaSystemSignArea> CaSystemSignAreaList { get; set; }

        /// <summary>
        /// 单次请求文件唯一id，与AntSignFileRequest中的fileId对应
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
