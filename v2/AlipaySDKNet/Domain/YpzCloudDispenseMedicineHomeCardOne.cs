using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzCloudDispenseMedicineHomeCardOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzCloudDispenseMedicineHomeCardOne : AopObject
    {
        /// <summary>
        /// 按钮文案
        /// </summary>
        [XmlElement("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("node_list")]
        [XmlArrayItem("ypz_cloud_dispense_medicine_card_node")]
        public List<YpzCloudDispenseMedicineCardNode> NodeList { get; set; }

        /// <summary>
        /// 按钮跳转URL
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
