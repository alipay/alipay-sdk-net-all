using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotDeliveryContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IotDeliveryContentInfo : AopObject
    {
        /// <summary>
        /// 活动id 列表，最大数量 2  说明： 通过alipay.marketing.activity.ordervoucher.create 创建的导码模式的商家券活动
        /// </summary>
        [XmlElement("activity_ids")]
        public string ActivityIds { get; set; }

        /// <summary>
        /// 当有承接券信息的小程序时返回
        /// </summary>
        [XmlElement("display_app_id")]
        public string DisplayAppId { get; set; }
    }
}
