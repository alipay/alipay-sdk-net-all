using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationShopMemberAddOption Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationShopMemberAddOption : AopObject
    {
        /// <summary>
        /// 增加方式对应的业务值 如类型选择为TRADE_NO,则该值为订单号实际值
        /// </summary>
        [XmlElement("biz_value")]
        public string BizValue { get; set; }

        /// <summary>
        /// 物理门店资产增加方式类型 TRADE_NO：通过订单号增加账户
        /// </summary>
        [XmlElement("option_type")]
        public string OptionType { get; set; }
    }
}
