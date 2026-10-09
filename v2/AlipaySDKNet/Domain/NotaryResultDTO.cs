using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NotaryResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class NotaryResultDTO : AopObject
    {
        /// <summary>
        /// 文本存证内容，仅文本存证上链有该值
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 存证申请时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 上链状态：上链中|上链成功|上链失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 状态为上链中时，该时间为上链时间，上链成功时，该时间会更新成上链成功时间
        /// </summary>
        [XmlElement("sync_chain_time")]
        public string SyncChainTime { get; set; }

        /// <summary>
        /// 存证凭据
        /// </summary>
        [XmlElement("tx_hash")]
        public string TxHash { get; set; }

        /// <summary>
        /// 存证类型：文本|文件
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 文件预览路径，仅文件存证上链返回该值，该临时链接有效期5分钟，过期后点击查询会重新生成新的链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
