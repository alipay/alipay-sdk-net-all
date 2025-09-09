using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentGoodsInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentGoodsInfoDTO : AopObject
    {
        /// <summary>
        /// 商品总价值，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("item_value")]
        public string ItemValue { get; set; }

        /// <summary>
        /// 租赁模式
        /// </summary>
        [XmlElement("rent_model")]
        public string RentModel { get; set; }

        /// <summary>
        /// 是否监管机
        /// </summary>
        [XmlElement("supervised")]
        public bool Supervised { get; set; }
    }
}
