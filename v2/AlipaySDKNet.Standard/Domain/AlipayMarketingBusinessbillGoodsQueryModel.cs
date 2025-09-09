using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBusinessbillGoodsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBusinessbillGoodsQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝分配的场景编码
        /// </summary>
        [XmlElement("activity_scene")]
        public string ActivityScene { get; set; }

        /// <summary>
        /// 根据商品编码查询
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 依据商品型号模糊查询
        /// </summary>
        [XmlElement("goods_model_number")]
        public string GoodsModelNumber { get; set; }

        /// <summary>
        /// 根据商品名称模糊查询
        /// </summary>
        [XmlElement("goods_title")]
        public string GoodsTitle { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
