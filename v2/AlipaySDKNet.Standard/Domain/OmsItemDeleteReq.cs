using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OmsItemDeleteReq Data Structure.
    /// </summary>
    [Serializable]
    public class OmsItemDeleteReq : AopObject
    {
        /// <summary>
        /// 系统注册账号名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 创建药品的时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 删除药品的时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("delete_time")]
        public string DeleteTime { get; set; }

        /// <summary>
        /// 商家中台系统里药品的编码，由商家自定义
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 平台药品的编码，由支付宝返回
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 门店商品的名称，例如：[地奥]银黄含片 0.65g*12片*2板
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 用于区分商品的修改端，枚举值：0 PC端 1 openapi
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 商品店内分类编码, 标准分类码值参照标准分类文档, 自定义分类码值由创建分类时厂商自定指定
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 展示当前商品所在末级分类的分类名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
