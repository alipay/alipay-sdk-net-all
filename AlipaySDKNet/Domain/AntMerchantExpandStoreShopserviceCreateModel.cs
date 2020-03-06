using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandStoreShopserviceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandStoreShopserviceCreateModel : AopObject
    {
        /// <summary>
        /// 素材上传的安全云oss的accessKey
        /// </summary>
        [XmlElement("access_key_id")]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 场景服务名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商家接收通知的手机号
        /// </summary>
        [XmlElement("notify_phone")]
        public string NotifyPhone { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 具体描述预约的业务场景
        /// </summary>
        [XmlElement("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// 线下门店的服务项目列表
        /// </summary>
        [XmlArray("service_items")]
        [XmlArrayItem("shop_service_item")]
        public List<ShopServiceItem> ServiceItems { get; set; }

        /// <summary>
        /// 服务时间信息
        /// </summary>
        [XmlElement("service_time")]
        public ServiceTimeInfo ServiceTime { get; set; }

        /// <summary>
        /// 线下门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 服务人员
        /// </summary>
        [XmlArray("shop_staffs")]
        [XmlArrayItem("shop_staff_info")]
        public List<ShopStaffInfo> ShopStaffs { get; set; }

        /// <summary>
        /// 线上店的ID
        /// </summary>
        [XmlElement("store_open_id")]
        public string StoreOpenId { get; set; }
    }
}
