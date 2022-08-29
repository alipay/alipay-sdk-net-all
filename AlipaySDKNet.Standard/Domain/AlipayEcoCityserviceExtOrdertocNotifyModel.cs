using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceExtOrdertocNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceExtOrdertocNotifyModel : AopObject
    {
        /// <summary>
        /// 光华平台服务编码
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 扩展信息 ext_info Map<String,String>  |__ 名称  类型 是否必填 最大长度 描述 示例 |__ good_info_list List<GoodsOrder> 是 / 商品信息列表 [{"goodsName":"芝芝莓莓","goodsId":"12345","quantity":1}],  |__ goods_id String 是 128 商品Id S-101963  |__ goods_name String 是 128 商品名称 站点加油  |__ cover_pic_url String 否 256 商品图片  |__ price String 否 128 商品价格 ?120.00  |__ quantity int 否 / 商品数量 40  |__ simple_desc String 是 128 短文案 请尽快预约上门取件时间  |__ desc String 是 128 详细文案 宝贝需要寄送至服务点服务，请尽快完成预约  |__ partner_name String 是 128 服务商家 杭州美立洁环保科技有限公司  |__ appointment_time String / 128 预约时间 2022-04-24 15:20:00  |__ address String / 128 上门地址 云台路xxx号  |__ worker String / 128 服务人员 张三  |__ temperature String / 128 体温 36.5  |__ action String 是 128 行动点 查看详情  |__ action_url String 是 1024 行动点链接 google.com  |__ category String 是 128 商品类目 保洁收纳  |__ parent_status String 是 128 父状态 待服务  |__ payment_time Date 是 128 支付时间 2022-04-23 15:20:00
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品行列表
        /// </summary>
        [XmlElement("goods_info_list")]
        public string GoodsInfoList { get; set; }

        /// <summary>
        /// 行业类型 家服订单：7
        /// </summary>
        [XmlElement("industry_type")]
        public long IndustryType { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_update_time")]
        public string OrderUpdateTime { get; set; }

        /// <summary>
        /// 外部订单号，会用作幂等，幂等维度outerOrderNo+appId。注意防重。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板Id 请联系BD获取
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
