using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PtcNewGoodsApplyRequestVo Data Structure.
    /// </summary>
    [Serializable]
    public class PtcNewGoodsApplyRequestVo : AopObject
    {
        /// <summary>
        /// 算法ID，该字段值来源于行业云，由行业云同步该值到支付宝
        /// </summary>
        [XmlElement("algorithm_id")]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// 上新申请ID，该字段值来源于行业云，由行业云同步该值到支付宝
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("apply_open_id")]
        public string ApplyOpenId { get; set; }

        /// <summary>
        /// 申请状态 1(待采购[静]) 2(待信息审核[静]) 3(待到货审核[静]) 4(待学习[静]) 5(待审核[动]) 6(已上架) 7(已拒绝)
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        [XmlElement("apply_user")]
        public string ApplyUser { get; set; }

        /// <summary>
        /// 业务来源 API(api接口)、MINI_APP(小程序上新申请)
        /// </summary>
        [XmlElement("business_source")]
        public string BusinessSource { get; set; }

        /// <summary>
        /// 官方商品分类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 删除状态 0可用 1已删除
        /// </summary>
        [XmlElement("deleted")]
        public long Deleted { get; set; }

        /// <summary>
        /// 进深[毫米]
        /// </summary>
        [XmlElement("depth")]
        public string Depth { get; set; }

        /// <summary>
        /// 实物审核人
        /// </summary>
        [XmlElement("entity_audit_open_id")]
        public string EntityAuditOpenId { get; set; }

        /// <summary>
        /// 实物审核时间[静]
        /// </summary>
        [XmlElement("entity_audit_time")]
        public string EntityAuditTime { get; set; }

        /// <summary>
        /// 实物审核人
        /// </summary>
        [XmlElement("entity_audit_user")]
        public string EntityAuditUser { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("express_number")]
        public string ExpressNumber { get; set; }

        /// <summary>
        /// 上架操作人
        /// </summary>
        [XmlElement("finish_open_id")]
        public string FinishOpenId { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 上架操作人
        /// </summary>
        [XmlElement("finish_user")]
        public string FinishUser { get; set; }

        /// <summary>
        /// 经销商id，该字段值来源于行业云，由行业云同步该值到支付宝
        /// </summary>
        [XmlElement("franchisee_id")]
        public string FranchiseeId { get; set; }

        /// <summary>
        /// 商品大类
        /// </summary>
        [XmlElement("goods_big_type")]
        public string GoodsBigType { get; set; }

        /// <summary>
        /// 外部商品id，，该字段值来源于行业云，由行业云同步该值到支付宝
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品小类
        /// </summary>
        [XmlElement("goods_small_type")]
        public string GoodsSmallType { get; set; }

        /// <summary>
        /// 国标码
        /// </summary>
        [XmlElement("goods_upc")]
        public string GoodsUpc { get; set; }

        /// <summary>
        /// 高[毫米]
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 图片信息
        /// </summary>
        [XmlElement("img_info")]
        public string ImgInfo { get; set; }

        /// <summary>
        /// 信息审核人
        /// </summary>
        [XmlElement("info_audit_open_id")]
        public string InfoAuditOpenId { get; set; }

        /// <summary>
        /// 信息审核时间[静]|审核时间[动]
        /// </summary>
        [XmlElement("info_audit_time")]
        public string InfoAuditTime { get; set; }

        /// <summary>
        /// 信息审核人
        /// </summary>
        [XmlElement("info_audit_user")]
        public string InfoAuditUser { get; set; }

        /// <summary>
        /// 是否20g以下商品
        /// </summary>
        [XmlElement("low_weight_goods")]
        public long LowWeightGoods { get; set; }

        /// <summary>
        /// 主观算法ID，该字段值来源于行业云，由行业云同步该值到支付宝
        /// </summary>
        [XmlElement("main_algorithm_id")]
        public string MainAlgorithmId { get; set; }

        /// <summary>
        /// 商家appId
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商家pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 上新类型:0(静态)、1(动态-标准)、2(动态-非标)、3(动态-系列)、4(动态-系列-更新)
        /// </summary>
        [XmlElement("new_goods_apply_type")]
        public string NewGoodsApplyType { get; set; }

        /// <summary>
        /// 软包类-型
        /// </summary>
        [XmlElement("pack_type")]
        public string PackType { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 采购链接
        /// </summary>
        [XmlElement("purchase_link")]
        public string PurchaseLink { get; set; }

        /// <summary>
        /// 审核驳回描述信息
        /// </summary>
        [XmlElement("reject_msg")]
        public string RejectMsg { get; set; }

        /// <summary>
        /// 重复商品算法id，该字段值来源于行业云，由行业云同步该值到支付宝
        /// </summary>
        [XmlElement("repeat_algorithm_id")]
        public string RepeatAlgorithmId { get; set; }

        /// <summary>
        /// 重复商品code
        /// </summary>
        [XmlElement("repeat_goods_code")]
        public string RepeatGoodsCode { get; set; }

        /// <summary>
        /// 样本重量[克] 多个,分割
        /// </summary>
        [XmlElement("sample_weight")]
        public string SampleWeight { get; set; }

        /// <summary>
        /// 商品识别类型 STATIC_STATE(静态)、DYNAMIC_STATE(动态)
        /// </summary>
        [XmlElement("sell_goods_type")]
        public string SellGoodsType { get; set; }

        /// <summary>
        /// 是否标准商品
        /// </summary>
        [XmlElement("standard_goods")]
        public long StandardGoods { get; set; }

        /// <summary>
        /// 是否标准售卖商品(0非标 1标品)
        /// </summary>
        [XmlElement("standard_saleable_goods")]
        public long StandardSaleableGoods { get; set; }

        /// <summary>
        /// 提供方式 purchaseLink(采购链接)、expressNumber(快递单号)
        /// </summary>
        [XmlElement("transport_type")]
        public string TransportType { get; set; }

        /// <summary>
        /// 重力标 0不支持重力 1支持重力
        /// </summary>
        [XmlElement("weight_goods")]
        public long WeightGoods { get; set; }

        /// <summary>
        /// 宽[毫米]
        /// </summary>
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
