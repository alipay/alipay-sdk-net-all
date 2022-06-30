using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnvironmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnvironmentInfo : AopObject
    {
        /// <summary>
        /// 对应商品有环保类型时，需要返回;一个商品可能有多个环保类型
        /// </summary>
        [XmlArray("environmental_list")]
        [XmlArrayItem("environmental")]
        public List<Environmental> EnvironmentalList { get; set; }

        /// <summary>
        /// 商品码，根据入参时的商品码进行返回; (其中临期商品一笔订单只返回一个环保类型对应其中一个商品）
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
