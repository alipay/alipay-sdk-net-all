using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcpormoDataCheckInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MpcpormoDataCheckInfo : AopObject
    {
        /// <summary>
        /// 校验信息
        /// </summary>
        [XmlElement("check_info")]
        public string CheckInfo { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
