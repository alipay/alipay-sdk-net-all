using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantItemExtParam Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantItemExtParam : AopObject
    {
        /// <summary>
        /// 扩展信息查询，如淘宝定向优惠渠道参数，是否猫超商品等
        /// </summary>
        [XmlElement("param_key")]
        public string ParamKey { get; set; }

        /// <summary>
        /// 参数key对应的具体值
        /// </summary>
        [XmlElement("param_value")]
        public string ParamValue { get; set; }
    }
}
