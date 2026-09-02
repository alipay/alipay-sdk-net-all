using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNfcexpoprodOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNfcexpoprodOrderCreateModel : AopObject
    {
        /// <summary>
        /// 订单的描述文案，长度不要超过256个字符
        /// </summary>
        [XmlElement("order_desc")]
        public string OrderDesc { get; set; }

        /// <summary>
        /// 业务自行生成的唯一值，用于幂等校验
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 下单物料的生产资料信息
        /// </summary>
        [XmlElement("production_material")]
        public ProductionMaterial ProductionMaterial { get; set; }

        /// <summary>
        /// 下单物料数量（个）
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 用户收货地址
        /// </summary>
        [XmlElement("shipping_address")]
        public NcoilopenAddressInfo ShippingAddress { get; set; }

        /// <summary>
        /// 标识订单所属的解决方案，用于业务归类和路由
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 标识订单所属的子解决方案，用于更细粒度的业务归类
        /// </summary>
        [XmlElement("sub_solution_id")]
        public string SubSolutionId { get; set; }

        /// <summary>
        /// 模板编码，对应 商品的模板唯一标识，用于确定下单的商品类型和规格
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
