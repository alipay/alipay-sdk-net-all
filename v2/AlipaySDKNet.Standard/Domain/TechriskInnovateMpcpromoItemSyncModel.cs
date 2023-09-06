using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoItemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoItemSyncModel : AopObject
    {
        /// <summary>
        /// 被授权小程序appid
        /// </summary>
        [XmlElement("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("mpc_item_v_o")]
        public List<MpcItemVO> ItemList { get; set; }
    }
}
