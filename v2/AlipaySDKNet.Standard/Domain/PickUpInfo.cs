using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PickUpInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PickUpInfo : AopObject
    {
        /// <summary>
        /// 自提地址（展示的地址）
        /// </summary>
        [XmlElement("pick_up_address")]
        public string PickUpAddress { get; set; }

        /// <summary>
        /// 类型对应取餐码，待自取及之后状态必填。建议生成该字段时即回传。
        /// </summary>
        [XmlElement("pick_up_code")]
        public string PickUpCode { get; set; }

        /// <summary>
        /// 自提门店名称
        /// </summary>
        [XmlElement("pick_up_shop_name")]
        public string PickUpShopName { get; set; }

        /// <summary>
        /// 取餐凭证类型。待自取及之后状态必填。整体状态生命周期中，必须回传1次。枚举支持：自提码-SELF_PICK_CODE ；口令-PASSWORD；取餐码-MEAL_NUM
        /// </summary>
        [XmlElement("pick_up_type")]
        public string PickUpType { get; set; }

        /// <summary>
        /// 桌号，点餐先付-送餐到桌场景必填
        /// </summary>
        [XmlElement("table_num")]
        public string TableNum { get; set; }
    }
}
