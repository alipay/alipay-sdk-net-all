using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntarchiveFaceQueryResponse.
    /// </summary>
    public class AlipayUserAntarchiveFaceQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回人脸图片类型列表.若不存在则返回空列表
        /// </summary>
        [XmlArray("archive_face_list")]
        [XmlArrayItem("archive_face_info")]
        public List<ArchiveFaceInfo> ArchiveFaceList { get; set; }

        /// <summary>
        /// 是否存在本地可用比对源图片
        /// </summary>
        [XmlElement("local_usable")]
        public bool LocalUsable { get; set; }

        /// <summary>
        /// 是否存在远程可用比对源图片
        /// </summary>
        [XmlElement("remote_usable")]
        public bool RemoteUsable { get; set; }
    }
}
