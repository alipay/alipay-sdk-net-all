using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentFile Data Structure.
    /// </summary>
    [Serializable]
    public class RentFile : AopObject
    {
        /// <summary>
        /// 支付宝文件系统的afts的key，取值：通过支付宝文件上传接口获取
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件的名称，取值：基于上传的文件决定
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件的访问地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
