using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDescInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDescInfoVO : AopObject
    {
        /// <summary>
        /// 商品详情描述文本（不超过2000字）。若接入商品详情页组件，将在详情页组件处透出。
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品详情描述图片（最多10张），图片宽为750px，高度小于3000px。文件id通过alipay.open.file.upload上传资源获取。若接入商品详情页组件，将在详情页组件处透出。
        /// </summary>
        [XmlArray("imgs")]
        [XmlArrayItem("string")]
        public List<string> Imgs { get; set; }
    }
}
