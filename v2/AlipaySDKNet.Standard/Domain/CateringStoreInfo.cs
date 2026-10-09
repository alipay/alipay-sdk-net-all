using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateringStoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CateringStoreInfo : AopObject
    {
        /// <summary>
        /// 门店营业时间；门店营业时间与服务营业时间二选一必填
        /// </summary>
        [XmlElement("business_hours")]
        public BusinessHoursInfo BusinessHours { get; set; }

        /// <summary>
        /// 外卖相关参数
        /// </summary>
        [XmlElement("delivery_info")]
        public CateringStoreDeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// 人均消费。单位为元，精确到小数点后两位。
        /// </summary>
        [XmlElement("per_consumption")]
        public string PerConsumption { get; set; }

        /// <summary>
        /// 支付宝门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店地址信息
        /// </summary>
        [XmlElement("store_address_info")]
        public StoreAddressInfo StoreAddressInfo { get; set; }

        /// <summary>
        /// 门店城市
        /// </summary>
        [XmlElement("store_city")]
        public string StoreCity { get; set; }

        /// <summary>
        /// 门店扩展字段，key：store_marking，value：pre_authorization
        /// </summary>
        [XmlArray("store_extra_info")]
        [XmlArrayItem("extra_info")]
        public List<ExtraInfo> StoreExtraInfo { get; set; }

        /// <summary>
        /// 商家门店id（ISV内部门店唯一编号）
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称，比如：蚂蚁金服店，不需要“(”  “)”等辅助标记，与门店名称合并后对外展示如星巴克(蚂蚁金服店)
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店联系方式，支持手机号和固定电话。请输入合法的手机号码或者固定号码，其中其中固定号码的区号3到4位，电话7到8位，分机号选填(例：固定电话：0834-1133567 或者 0834-1133567-1234）
        /// </summary>
        [XmlElement("store_phone")]
        public string StorePhone { get; set; }
    }
}
