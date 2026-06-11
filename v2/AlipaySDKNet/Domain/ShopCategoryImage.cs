using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopCategoryImage Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCategoryImage : AopObject
    {
        /// <summary>
        /// 二级类目code。注意这里要填的是【二级code】。
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 二级类目所对应的类目图 文件id 来源于alipay.open.file.upload支付宝文件上传接口
        /// </summary>
        [XmlElement("category_image")]
        public string CategoryImage { get; set; }
    }
}
