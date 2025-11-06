using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasItemQueryModel : AopObject
    {
        /// <summary>
        /// 商品前台类目id: null 表示所有分类
        /// </summary>
        [XmlElement("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品状态：EFFECT、INVALID、PAUSE；不填返回所有状态商品
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品归属主体id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型: 5: 店铺 4: 主站MID 3: 参与者 2: 角色 1: 联系人
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
