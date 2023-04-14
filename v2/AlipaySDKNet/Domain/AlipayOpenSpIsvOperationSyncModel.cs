using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpIsvOperationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpIsvOperationSyncModel : AopObject
    {
        /// <summary>
        /// 客户类型，PERSONAL表示个人，ALIPAY_RECOMMEND表示支付宝推荐
        /// </summary>
        [XmlElement("customer_type")]
        public string CustomerType { get; set; }

        /// <summary>
        /// 拓展字段回传
        /// </summary>
        [XmlElement("ext_info")]
        public OperationResultExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 实施结束时间
        /// </summary>
        [XmlElement("implement_end_time")]
        public string ImplementEndTime { get; set; }

        /// <summary>
        /// 实施对象名称
        /// </summary>
        [XmlElement("implement_object_name")]
        public string ImplementObjectName { get; set; }

        /// <summary>
        /// 实施地点
        /// </summary>
        [XmlElement("implement_place")]
        public string ImplementPlace { get; set; }

        /// <summary>
        /// 实施结果，SUCCESS表示实施成功，FAIL表示实施失败
        /// </summary>
        [XmlElement("implement_result")]
        public string ImplementResult { get; set; }

        /// <summary>
        /// 实施结果的照片
        /// </summary>
        [XmlElement("implement_result_image")]
        public string ImplementResultImage { get; set; }

        /// <summary>
        /// 实施结果的备注
        /// </summary>
        [XmlElement("implement_result_remark")]
        public string ImplementResultRemark { get; set; }

        /// <summary>
        /// 实施开始时间
        /// </summary>
        [XmlElement("implement_start_time")]
        public string ImplementStartTime { get; set; }

        /// <summary>
        /// 服务优选商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品价格，这里填写的是整数，单位为分，比如1元，那么输入100
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商品小程序appid，若推广的商品不为小程序，则不传此参数
        /// </summary>
        [XmlElement("mini_appid")]
        public string MiniAppid { get; set; }

        /// <summary>
        /// 拓展助手中的商机id
        /// </summary>
        [XmlElement("oppor_id")]
        public string OpporId { get; set; }

        /// <summary>
        /// 下单订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，传isv系统生成的账单号，需要保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 推广服务商(S2)pid
        /// </summary>
        [XmlElement("promotor_pid")]
        public string PromotorPid { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 推广服务商(S2)子账号pid
        /// </summary>
        [XmlElement("sub_promotor_pid")]
        public string SubPromotorPid { get; set; }
    }
}
