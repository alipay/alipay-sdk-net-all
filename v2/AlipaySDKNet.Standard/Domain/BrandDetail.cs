using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BrandDetail : AopObject
    {
        /// <summary>
        /// 搜索工单详情数据block_type
        /// </summary>
        [XmlElement("block_type")]
        public string BlockType { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("box_version")]
        public string BoxVersion { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// img地址
        /// </summary>
        [XmlElement("img")]
        public string Img { get; set; }

        /// <summary>
        /// 索引信息
        /// </summary>
        [XmlElement("index")]
        public string Index { get; set; }

        /// <summary>
        /// 工单详情数据key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 工单详情数据material_id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 搜索运营工单详情数据public_bind_app_id
        /// </summary>
        [XmlElement("public_bind_app_id")]
        public string PublicBindAppId { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
