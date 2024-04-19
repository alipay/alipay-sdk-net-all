using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgOrderGoodsInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class MsgOrderGoodsInfoList : AopObject
    {
        /// <summary>
        /// 事项描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 具体办事描述
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 事项编码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 事项名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 图片地址需要以https开头的域名地址
        /// </summary>
        [XmlElement("goods_pic")]
        public string GoodsPic { get; set; }
    }
}
