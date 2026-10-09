using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelShopReportCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelShopReportCallbackModel : AopObject
    {
        /// <summary>
        /// 数据版本
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 外部店铺id
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 店铺上报进度信息
        /// </summary>
        [XmlElement("progress_info")]
        public ShopReportProgressInfo ProgressInfo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果消息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
