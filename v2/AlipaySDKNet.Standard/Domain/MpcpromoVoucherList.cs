using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcpromoVoucherList Data Structure.
    /// </summary>
    [Serializable]
    public class MpcpromoVoucherList : AopObject
    {
        /// <summary>
        /// 创建商家券活动成功后获取
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 可用城市列表
        /// </summary>
        [XmlArray("available_city_list")]
        [XmlArrayItem("string")]
        public List<string> AvailableCityList { get; set; }

        /// <summary>
        /// 券可使用的门店列表列表
        /// </summary>
        [XmlArray("available_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> AvailableShopIds { get; set; }

        /// <summary>
        /// 不同标签用，分隔
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 1、服务商平台模式即belong_merchant_info.business_type为ISV时必传 2、上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 1、服务商平台模式即belong_merchant_info.business_type为ISV时必传
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 客服电话和客服链接必须二选一
        /// </summary>
        [XmlElement("customer_service_mobile")]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 客服链接
        /// </summary>
        [XmlElement("customer_service_url")]
        public string CustomerServiceUrl { get; set; }

        /// <summary>
        /// 领券请求失败
        /// </summary>
        [XmlElement("on_get_coupon_fail")]
        public string OnGetCouponFail { get; set; }

        /// <summary>
        /// 领券请求成功调用的事件，领券结果可能成功也可能失败。
        /// </summary>
        [XmlElement("on_get_coupon_success")]
        public string OnGetCouponSuccess { get; set; }

        /// <summary>
        /// 商家券领券跳转链接、自定义活动地址
        /// </summary>
        [XmlElement("on_get_coupon_url")]
        public string OnGetCouponUrl { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券可领结束时间
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券可领开始时间
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 发放者商户号
        /// </summary>
        [XmlElement("sender_merchant_id")]
        public string SenderMerchantId { get; set; }

        /// <summary>
        /// 券总量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 商家券类型：满减、折扣、团购
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 1、该字段目前只支持兑换券即voucher_type为EXCHANGE_VOUCHER
        /// </summary>
        [XmlElement("voucher_comment")]
        public string VoucherComment { get; set; }

        /// <summary>
        /// 券详细使用说明
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 1、voucher_image填入，该值才能填入； 2、最多3张； 3、兑换券即voucher_type为EXCHANGE_VOUCHER时不支持
        /// </summary>
        [XmlArray("voucher_detail_images")]
        [XmlArrayItem("string")]
        public List<string> VoucherDetailImages { get; set; }

        /// <summary>
        /// 该字段在兑换券场景下必传，上传图片尺寸670*335，支持格式：png、jpg、jpeg、bmp，大小不超过2MB
        /// </summary>
        [XmlElement("voucher_image")]
        public string VoucherImage { get; set; }

        /// <summary>
        /// 优惠规则
        /// </summary>
        [XmlElement("voucher_rule")]
        public string VoucherRule { get; set; }
    }
}
