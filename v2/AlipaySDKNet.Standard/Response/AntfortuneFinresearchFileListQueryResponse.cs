using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchFileListQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchFileListQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件详情
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("z_x_z_file_detail")]
        public List<ZXZFileDetail> FileList { get; set; }
    }
}
