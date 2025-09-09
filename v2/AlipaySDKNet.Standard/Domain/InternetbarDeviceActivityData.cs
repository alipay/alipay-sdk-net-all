using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InternetbarDeviceActivityData Data Structure.
    /// </summary>
    [Serializable]
    public class InternetbarDeviceActivityData : AopObject
    {
        /// <summary>
        /// 该线圈历史上是否曾唤起过支付宝端
        /// </summary>
        [XmlElement("awake_app")]
        public bool AwakeApp { get; set; }

        /// <summary>
        /// 动销数据对应的业务发生日期
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 线圈当日DAU
        /// </summary>
        [XmlElement("device_dau")]
        public long DeviceDau { get; set; }

        /// <summary>
        /// 线圈当日pv值
        /// </summary>
        [XmlElement("device_pv")]
        public long DevicePv { get; set; }

        /// <summary>
        /// 网吧门店编号
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }

        /// <summary>
        /// 网吧门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 网吧门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 线圈的tagId
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
