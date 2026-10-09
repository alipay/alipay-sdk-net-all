using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZXZMessageCard Data Structure.
    /// </summary>
    [Serializable]
    public class ZXZMessageCard : AopObject
    {
        /// <summary>
        /// 详细内容，详情请看文档 《openapi标准化接口》 4.2
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 执行状态 pending 等待中 running 执行中 success 执行成功 fail 失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 4Eprocess 4e过程，当前未开放 answer 答案卡片
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
