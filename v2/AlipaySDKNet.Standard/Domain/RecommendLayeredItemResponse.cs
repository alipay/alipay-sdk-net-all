using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendLayeredItemResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendLayeredItemResponse : AopObject
    {
        /// <summary>
        /// 商品分层标签，传递分层分层信息。 比如：full-price-delivery代表原价供货，3小时内到账，否则自动退款。 101-delivery 代表溢价1%供货，半小时到账。
        /// </summary>
        [XmlElement("discount_phone_perform_level_tag")]
        public string DiscountPhonePerformLevelTag { get; set; }

        /// <summary>
        /// 单元：元。 话费面值。 用户要对自己的手机号进行充值的面额，比如50，100，200。
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 支付宝侧商品ID，下单时需要把该字段传入。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 单位：元 表示当前商品的价值，会带有小数点后两位。 商品价格，50.00表示当前面额的价格为50元，但商品价格和面额不一定等价，也就是50的面额价格不一定是50.00元。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
