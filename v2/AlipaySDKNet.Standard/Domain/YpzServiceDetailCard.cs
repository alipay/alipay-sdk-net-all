using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzServiceDetailCard Data Structure.
    /// </summary>
    [Serializable]
    public class YpzServiceDetailCard : AopObject
    {
        /// <summary>
        /// 主按钮文案
        /// </summary>
        [XmlElement("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// 左按钮文案
        /// </summary>
        [XmlElement("button_text_left")]
        public string ButtonTextLeft { get; set; }

        /// <summary>
        /// 右按钮文案
        /// </summary>
        [XmlElement("button_text_right")]
        public string ButtonTextRight { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 卡描述(副标题)
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("ext")]
        public YpzServiceDetailCardExt Ext { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("node_list")]
        [XmlArrayItem("ypz_cloud_dispense_medicine_card_node")]
        public List<YpzCloudDispenseMedicineCardNode> NodeList { get; set; }

        /// <summary>
        /// 主按钮跳转地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 左按钮跳转地址
        /// </summary>
        [XmlElement("redirect_url_left")]
        public string RedirectUrlLeft { get; set; }

        /// <summary>
        /// 右按钮跳转地址
        /// </summary>
        [XmlElement("redirect_url_right")]
        public string RedirectUrlRight { get; set; }

        /// <summary>
        /// 卡状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 卡状态文案
        /// </summary>
        [XmlElement("status_text")]
        public string StatusText { get; set; }

        /// <summary>
        /// 卡标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 唯一id
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
