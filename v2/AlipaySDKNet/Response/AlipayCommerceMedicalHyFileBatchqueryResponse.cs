using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHyFileBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHyFileBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("hy_file_meta")]
        public List<HyFileMeta> FileList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("hy_file_meta")]
        public List<HyFileMeta> ImageList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("video_list")]
        [XmlArrayItem("hy_file_meta")]
        public List<HyFileMeta> VideoList { get; set; }
    }
}
