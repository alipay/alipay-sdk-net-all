using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSystemSignFileRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CaSystemSignFileRequest : AopObject
    {
        /// <summary>
        /// 签署区域信息（包括印模信息）
        /// </summary>
        [XmlArray("ca_system_sign_area_request_list")]
        [XmlArrayItem("ca_system_sign_area_request")]
        public List<CaSystemSignAreaRequest> CaSystemSignAreaRequestList { get; set; }

        /// <summary>
        /// 和签署文件列表fileId呼应，必传字段
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
