using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CheckOrderData Data Structure.
    /// </summary>
    [Serializable]
    public class CheckOrderData : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("check_item_list")]
        [XmlArrayItem("check_item_data")]
        public List<CheckItemData> CheckItemList { get; set; }

        /// <summary>
        /// 检测单号
        /// </summary>
        [XmlElement("check_no")]
        public string CheckNo { get; set; }
    }
}
