using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerGuideModify Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerGuideModify : AopObject
    {
        /// <summary>
        /// 券可用的小程序appId，卡包详情页可跳转到该appId 限制： 该appId归属的pid必须和当前商户保持一致。 目前mini_app_id、shop_ids、real_shop_ids必须三选一。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定跳转到mini_app_id时的具体页面路径。 限制： 1、只有mini_app_id有值时该值传入才会有效 2、该小程序路径是相对路径。详情参考小程序scheme链接介绍https://opendocs.alipay.com/support/01rb18
        /// </summary>
        [XmlElement("mini_app_path")]
        public string MiniAppPath { get; set; }

        /// <summary>
        /// 券可使用的商业关系门店列表,列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id   限制：  1、创建活动时传入了该值修改才会生效 2、real_shop_ids中的门店id必须是商业关系门店id。 3、real_shop_ids如果包含重复的门店id会自动进行去重操作。  4、修改门店列表，只允许增加不允许减少。 5、每次传入必须是全量的门店id即原来的门店+本次新增的门店id
        /// </summary>
        [XmlArray("real_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> RealShopIds { get; set; }

        /// <summary>
        /// 小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。 限制: 1.只有mini_app_id有值时该值传入才会有效 2.当前只支持一个服务code 3.service_codes与mini_app_path只能且必须二选一
        /// </summary>
        [XmlArray("service_codes")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodes { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。 接口参数是列表类型。 限制： 1、创建活动时传入了该值修改才会生效。 2、shop_ids中的门店id必须是支付宝门店id。 3、shop_ids如果包含重复的门店id会自动进行去重操作。 4、修改门店列表，只允许增加不允许减少。 5、每次传入必须是全量的门店id即原来的门店+本次新增的门店id
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 后续废弃。  券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。 接口参数是列表类型。  限制： 1、创建活动时传入了该值修改才会生效。 2、store_ids中的门店id必须是支付宝门店id。 3、store_ids如果包含重复的门店id会自动进行去重操作。 4、修改门店列表，只允许增加不允许减少。 5、每次传入必须是全量的门店id即原来的门店+本次新增的门店id
        /// </summary>
        [XmlArray("store_ids")]
        [XmlArrayItem("string")]
        public List<string> StoreIds { get; set; }

        /// <summary>
        /// 券发放引导信息
        /// </summary>
        [XmlElement("voucher_send_guide")]
        public VoucherSendGuideModify VoucherSendGuide { get; set; }

        /// <summary>
        /// 券核销引导信息
        /// </summary>
        [XmlElement("voucher_use_guide")]
        public VoucherUseGuideModify VoucherUseGuide { get; set; }
    }
}
