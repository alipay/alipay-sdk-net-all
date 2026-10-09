using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendItemInfo : AopObject
    {
        /// <summary>
        /// 单元：元。 话费面值，比如50/100/200 用户要对自己的手机号进行充值的金额。
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品价格，50.00表示当前面额的价格为50元，但商品价格和面额不一定等价，也就是50的面额价格不一定是50.00元。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
