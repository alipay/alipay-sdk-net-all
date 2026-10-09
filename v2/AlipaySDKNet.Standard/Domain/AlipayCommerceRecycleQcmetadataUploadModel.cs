using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleQcmetadataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleQcmetadataUploadModel : AopObject
    {
        /// <summary>
        /// 支付宝文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 元数据
        /// </summary>
        [XmlArray("metadata_list")]
        [XmlArrayItem("recycle_qc_metadata")]
        public List<RecycleQcMetadata> MetadataList { get; set; }
    }
}
