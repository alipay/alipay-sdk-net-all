using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemInfoVO : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public EduTrainExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 所属一级分类列表
        /// </summary>
        [XmlArray("first_cates")]
        [XmlArrayItem("cate_info_v_o")]
        public List<CateInfoVO> FirstCates { get; set; }

        /// <summary>
        /// serviceCode
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 热门
        /// </summary>
        [XmlElement("is_hot")]
        public string IsHot { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("ori_price")]
        public string OriPrice { get; set; }

        /// <summary>
        /// 父元素信息
        /// </summary>
        [XmlElement("p_item_info")]
        public PItemInfoVO PItemInfo { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        [XmlElement("position")]
        public string Position { get; set; }

        /// <summary>
        /// 价格、人均消费
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// scm埋点，前端埋点使用
        /// </summary>
        [XmlElement("scm")]
        public string Scm { get; set; }

        /// <summary>
        /// 所属二级分类列表
        /// </summary>
        [XmlArray("secend_cates")]
        [XmlArrayItem("cate_info_v_o")]
        public List<CateInfoVO> SecendCates { get; set; }

        /// <summary>
        /// 来源标识 支付宝：ALIPAY 淘宝：TB 口碑：KB 饿了么：ELM
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 提示信息 如：活动优惠信息列表
        /// </summary>
        [XmlArray("tips")]
        [XmlArrayItem("string")]
        public List<string> Tips { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
