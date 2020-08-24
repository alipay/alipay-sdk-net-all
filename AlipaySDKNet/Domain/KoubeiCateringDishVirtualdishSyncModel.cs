using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualdishSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishVirtualdishSyncModel : AopObject
    {
        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 虚拟分类菜设置
        /// </summary>
        [XmlArray("kbdish_virtual_dish_info_list")]
        [XmlArrayItem("kb_virtual_shop_info")]
        public List<KbVirtualShopInfo> KbdishVirtualDishInfoList { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
