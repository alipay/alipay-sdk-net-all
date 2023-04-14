using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataFile Data Structure.
    /// </summary>
    [Serializable]
    public class DataFile : AopObject
    {
        /// <summary>
        /// 文件访问地址
        /// </summary>
        [XmlElement("access_url")]
        public string AccessUrl { get; set; }

        /// <summary>
        /// 文件包含的数据类型。比如TAXRECEIPT代表税票
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }
    }
}
