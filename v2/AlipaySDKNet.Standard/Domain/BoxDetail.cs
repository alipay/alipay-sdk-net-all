using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BoxDetail : AopObject
    {
        /// <summary>
        /// 品牌box所属biz_id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [XmlElement("block_type")]
        public string BlockType { get; set; }

        /// <summary>
        /// 版本信息
        /// </summary>
        [XmlElement("box_version")]
        public string BoxVersion { get; set; }

        /// <summary>
        /// 详情描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("img")]
        public string Img { get; set; }

        /// <summary>
        /// 品牌box数据索引
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// 品牌box所属material_id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 提报应用名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 品牌box所属sub_service_code
        /// </summary>
        [XmlElement("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 跳转url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
