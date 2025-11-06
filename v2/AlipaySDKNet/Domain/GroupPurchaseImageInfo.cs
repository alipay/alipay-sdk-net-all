using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseImageInfo : AopObject
    {
        /// <summary>
        /// 资质图片，使用openApi接口ant.merchant.expand.indirect.image.upload上传获取到的image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("image_pic")]
        public string ImagePic { get; set; }
    }
}
