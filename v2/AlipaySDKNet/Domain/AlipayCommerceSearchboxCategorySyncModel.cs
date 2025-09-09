using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSearchboxCategorySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSearchboxCategorySyncModel : AopObject
    {
        /// <summary>
        /// 品牌box业务类型，业务约定值
        /// </summary>
        [XmlElement("box_biz_type")]
        public string BoxBizType { get; set; }

        /// <summary>
        /// 商户侧类目唯一键，支持字母数字及下划线，提报后不允许修改，类目变更可通过下线旧类目并新增新类目实现
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// logo图片素材ID，通过图片上传接口获取，不允许使用外部url
        /// </summary>
        [XmlElement("category_logo")]
        public string CategoryLogo { get; set; }

        /// <summary>
        /// 运营管理后台使用，不对客展示
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 正序排列，不传默认为最低优先级；默认排序仅在其他排序规则不生效时使用，规则参考业务接入文档
        /// </summary>
        [XmlElement("category_order")]
        public long CategoryOrder { get; set; }

        /// <summary>
        /// 对客展示用，传参规则见业务对接文档
        /// </summary>
        [XmlElement("category_title")]
        public string CategoryTitle { get; set; }
    }
}
