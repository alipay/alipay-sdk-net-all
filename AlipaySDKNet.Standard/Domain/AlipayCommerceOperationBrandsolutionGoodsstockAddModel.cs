using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBrandsolutionGoodsstockAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBrandsolutionGoodsstockAddModel : AopObject
    {
        /// <summary>
        /// 活动唯一标识
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商家活动库存修改列表，允许批量修改，单次最多修改10条
        /// </summary>
        [XmlArray("merchant_activity_goods_increase_stock")]
        [XmlArrayItem("merchant_activity_goods_stock_increase")]
        public List<MerchantActivityGoodsStockIncrease> MerchantActivityGoodsIncreaseStock { get; set; }

        /// <summary>
        /// 外部业务号，幂等使用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
