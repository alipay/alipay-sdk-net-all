using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniGoodsDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniGoodsDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlElement("activity_info")]
        public ActivityInfoDTO ActivityInfo { get; set; }

        /// <summary>
        /// 商品属性信息列表
        /// </summary>
        [XmlArray("attr_ext_info_list")]
        [XmlArrayItem("attr_ext_info_d_t_o")]
        public List<AttrExtInfoDTO> AttrExtInfoList { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商品类目树 当前字段已废弃(暂时未使用)
        /// </summary>
        [XmlElement("categories_tree")]
        public string CategoriesTree { get; set; }

        /// <summary>
        /// 价格日历
        /// </summary>
        [XmlArray("effective_dates")]
        [XmlArrayItem("effective_dates_d_t_o")]
        public List<EffectiveDatesDTO> EffectiveDates { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 提报支付券优惠时的商品id，用于关联使用支付券，需要和支付券上绑定商品goods_id相同。如果不使用支付券，该字段传入商品最小粒度的商品id（如：若商品有 sku 粒度，则传商品 sku 粒度的id）
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 商品图片，用于小程序订单中心展示，可通过 <a href="https://opendocs.alipay.com/mini/03l4lq?pathHash=c08922b1&scene=common">alipay.merchant.item.file.upload </a>接口上传素材获取素材id。默认使用已上报的商品库素材信息。
        /// </summary>
        [XmlElement("image_material_id")]
        public string ImageMaterialId { get; set; }

        /// <summary>
        /// 品牌编号；商品品牌信息参<a href="https://xfpzl.yuque.com/dgw58m/apg2ie/qlqvdv0dhsbldyhv#kIy4">https://xfpzl.yuque.com/dgw58m/apg2ie/qlqvdv0dhsbldyhv#kIy4 </a>考此文档传入品牌编号
        /// </summary>
        [XmlElement("item_brand")]
        public string ItemBrand { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 商品成色 当前字段已废弃(商品成色有成色和等级两个信息。该字段定义模糊。)
        /// </summary>
        [XmlElement("item_condition")]
        public string ItemCondition { get; set; }

        /// <summary>
        /// 单位元有优惠信息时需要传入，优惠方式sale_real_price与item_discount二选一sale_real_price使用场景：商品有单价优惠，传入商品实际成交单价item_discount使用场景：同时购买多件商品时存在优惠，传入优惠总额优惠计算参考：<a href="https://opendocs.alipay.com/mini/0ag2e1?pathHash=20b9a409">文档</a> 中资金平衡校验
        /// </summary>
        [XmlElement("item_discount")]
        public string ItemDiscount { get; set; }

        /// <summary>
        /// 商品成色
        /// </summary>
        [XmlElement("item_fineness")]
        public string ItemFineness { get; set; }

        /// <summary>
        /// 成色等级，成色为二手时需传入此字段
        /// </summary>
        [XmlElement("item_fineness_grade")]
        public string ItemFinenessGrade { get; set; }

        /// <summary>
        /// 商品分期信息
        /// </summary>
        [XmlElement("item_installment_info")]
        public ItemInstallmentInfoDTO ItemInstallmentInfo { get; set; }

        /// <summary>
        /// 最大售价，单位：元，保留两位小数
        /// </summary>
        [XmlElement("max_sale_price")]
        public string MaxSalePrice { get; set; }

        /// <summary>
        /// 最低售价，单位：元，保留两位小数
        /// </summary>
        [XmlElement("min_sale_price")]
        public string MinSalePrice { get; set; }

        /// <summary>
        /// 商户侧商品id，用于公域场景结算，会影响主播归因。私域场景无需传入，公域场景未传入会影响后续结算
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户侧商品sku_id，用于公域场景结算，如果商品有多个sku，需要传入准确的sku_id，无sku时不需要传入
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 平台商品版本号，用于查询商品快照
        /// </summary>
        [XmlElement("platform_item_version_id")]
        public string PlatformItemVersionId { get; set; }

        /// <summary>
        /// 默认值：FIXED
        /// </summary>
        [XmlElement("price_mode")]
        public string PriceMode { get; set; }

        /// <summary>
        /// 租赁商品扩展信息
        /// </summary>
        [XmlElement("rent_goods_info")]
        public RentGoodsInfoDTO RentGoodsInfo { get; set; }

        /// <summary>
        /// 租金信息，租赁商品特有
        /// </summary>
        [XmlElement("rent_info")]
        public RentInfoDTO RentInfo { get; set; }

        /// <summary>
        /// 商品单价，单位：元，精确到小数点后两位，注：租赁商品请传入日租金，如10元/天
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 商品真实单价，单位：元，精确到小数点后两位，有优惠信息时需要传入，优惠方式sale_real_price与item_discount二选一 sale_real_price使用场景：商品有单价优惠，传入商品实际成交单价 item_discount使用场景：同时购买多件商品时存在优惠，传入优惠总额 优惠计算参考：<a href="https://opendocs.alipay.com/mini/0ag2e1?pathHash=20b9a409">资金平衡校验</a> sale_real_price使用场景：商品有单价优惠，传入商品实际成交单价 item_discount使用场景：同时购买多件商品时存在优惠，传入优惠总额 优惠计算参考：<a href="https://opendocs.alipay.com/mini/0ag2e1?pathHash=20b9a409">资金平衡校验</a> 注：租赁商品请传入日租金，如10元/天
        /// </summary>
        [XmlElement("sale_real_price")]
        public string SaleRealPrice { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [XmlElement("show_url")]
        public string ShowUrl { get; set; }

        /// <summary>
        /// 演出票务信息
        /// </summary>
        [XmlElement("ticket_info")]
        public TicketInfoDTO TicketInfo { get; set; }
    }
}
