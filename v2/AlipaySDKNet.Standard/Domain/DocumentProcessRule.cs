using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DocumentProcessRule Data Structure.
    /// </summary>
    [Serializable]
    public class DocumentProcessRule : AopObject
    {
        /// <summary>
        /// 切分配置
        /// </summary>
        [XmlElement("chunk_config")]
        public ChunkConfig ChunkConfig { get; set; }

        /// <summary>
        /// 是否开启摘要
        /// </summary>
        [XmlElement("chunk_digest")]
        public bool ChunkDigest { get; set; }

        /// <summary>
        /// 是否开启相似问题生成
        /// </summary>
        [XmlElement("similar_question")]
        public bool SimilarQuestion { get; set; }
    }
}
