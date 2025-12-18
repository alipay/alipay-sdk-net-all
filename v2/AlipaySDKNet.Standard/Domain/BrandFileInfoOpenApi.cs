using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandFileInfoOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class BrandFileInfoOpenApi : AopObject
    {
        /// <summary>
        /// 需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 使用alipay.open.brand.auth.create品牌认证接口，传 授权材料证明文件时，如果是一级授权只传一级授权材料，如果是二级授权需要传一级、二级授权材料，以此类推，文件类型fileType=层级，比如fileType=L1，参考auth_level
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 证件的有效结束时间
        /// </summary>
        [XmlElement("valid_end")]
        public string ValidEnd { get; set; }

        /// <summary>
        /// 证件的有效开始时间
        /// </summary>
        [XmlElement("valid_start")]
        public string ValidStart { get; set; }
    }
}
