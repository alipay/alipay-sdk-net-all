using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemCategoryConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemCategoryConsultModel : AopObject
    {
        /// <summary>
        /// 商品的图片ID；获取方式：商品主图&子图&详情图
        /// </summary>
        [XmlElement("img_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// [{"value": "1","name": "售卖类（实物）"},{"value": "2","name": "租赁类（实物）"},{"value": "3","name": "付费充值/兑换类（虚拟）"}]
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商品详情页URL
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 需要录入的商品的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
