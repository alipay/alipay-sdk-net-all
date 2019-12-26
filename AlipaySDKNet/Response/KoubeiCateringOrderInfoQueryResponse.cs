using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringOrderInfoQueryResponse.
    /// </summary>
    public class KoubeiCateringOrderInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 应收金额，以元为单位，精确到分
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 业务类型：DINNER-正餐、SNACK-快餐
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// KOUBEI-口碑
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// FOR_HERE("FOR_HERE", "堂食"),  TAKE_OUT("TAKE_OUT", "外卖"),  TO_GO("TO_GO", "外带"),
        /// </summary>
        [XmlElement("dinner_type")]
        public string DinnerType { get; set; }

        /// <summary>
        /// 菜明细列表，使用 JSONObject.parseArray(dish_details,KbPosOrderDishDetail.class) 获取菜明细模型列表
        /// </summary>
        [XmlArray("dish_details")]
        [XmlArrayItem("kb_pos_order_dish_detail")]
        public List<KbPosOrderDishDetail> DishDetails { get; set; }

        /// <summary>
        /// 扩展信息，使用Map<String,String> extInfo = JSONObject.parseObject(ext_info,Map.class)转换，包含核销模式(key为settleMode，value为RECEIPT接单打款/VERIFY核销打款)，留桌时间或备餐截止时间(key为reserveTime，value为时间戳)，接单超时时间(key为receiptTimeout，value为时间戳)
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部门店id
        /// </summary>
        [XmlElement("external_shop_id")]
        public string ExternalShopId { get; set; }

        /// <summary>
        /// 是否享受会员价优惠
        /// </summary>
        [XmlElement("member_flag")]
        public string MemberFlag { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 下单方式：  PLATFORM——线上点，SCAN——扫码点
        /// </summary>
        [XmlElement("order_style")]
        public string OrderStyle { get; set; }

        /// <summary>
        /// 用户下单时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 其他杂费，以元为单位，精确到分
        /// </summary>
        [XmlElement("other_amount")]
        public string OtherAmount { get; set; }

        /// <summary>
        /// 打包费，以元为单位，精确到分
        /// </summary>
        [XmlElement("packing_amount")]
        public string PackingAmount { get; set; }

        /// <summary>
        /// 实付金额，以元为单位，精确到分
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 是一个list列表，value参考对象PosBillPayChannel 支付渠道列表信息，目前只会有一个支付渠道。使用 JSONObject.parseArray(pay_channels,PosBillPayChannel.class)获取
        /// </summary>
        [XmlArray("pay_channels")]
        [XmlArrayItem("pos_bill_pay_channel")]
        public List<PosBillPayChannel> PayChannels { get; set; }

        /// <summary>
        /// 就餐人数，int类型
        /// </summary>
        [XmlElement("people_num")]
        public string PeopleNum { get; set; }

        /// <summary>
        /// 实收金额，以元为单位，精确到分
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 服务费，以元为单位，精确到分
        /// </summary>
        [XmlElement("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 预订开台时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("table_time")]
        public string TableTime { get; set; }

        /// <summary>
        /// 取餐号码，示例： 桌号：04，令牌：13，取餐号：5100，配送：2018012912312312321（比如饿了么订单号）
        /// </summary>
        [XmlElement("take_no")]
        public string TakeNo { get; set; }

        /// <summary>
        /// 取餐类型：TABLE-桌号，NO-取餐号，NO_BOOK-取餐号（预约），TABLE_BOOK-预约桌号
        /// </summary>
        [XmlElement("take_style")]
        public string TakeStyle { get; set; }

        /// <summary>
        /// 应付金额，以元为单位，精确到分
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 用户手机号码，1864234324324
        /// </summary>
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }
    }
}
